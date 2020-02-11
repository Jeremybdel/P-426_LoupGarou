///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base permettant d'envoyer un mail avec un mot de passe aléatoire
///
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Werewolf
{
    public class SendMail
    {
        //Nombre de caractère dans le mail
        public const int NBCARACTER = 10;
        //Random 
        Random rnd = new Random();
        //Information pour permettre la connexion au serveur pour l'envoi du mail 
        SmtpClient smtp;
        /// <summary>
        /// Connexion de départ au serveur, le code viens de https://codes-sources.commentcamarche.net/source/48115-send-mail-with-gmail
        /// </summary>
        public void Connexion()
        {
            smtp = new SmtpClient("smtp.gmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
        }
        /// <summary>
        /// Envoi du mail, une grande partie du code viens de https://codes-sources.commentcamarche.net/source/48115-send-mail-with-gmail
        /// </summary>
        public string MailSend(string mailTo)
        {

            try
            {
                //Nouveau mot de passe
                char[] tab_chrNewMdp = new char[NBCARACTER];
                //Crée un mot de passe de 10 caractère de long
                for (int x = 0; x < NBCARACTER; x++)
                {
                    //Stock le nombre aléatoire qui permet de choisir 
                    int temp = rnd.Next(1, 4);
                    //Verfie le nombre aléatoire sorti est choisit le type de caractère alphanumérique
                    if (temp == 1)
                    {
                        //Choisit aléatoirement un caractère numérique
                        char caracter = Convert.ToChar(rnd.Next(48, 58));
                        tab_chrNewMdp[x] = caracter;
                    }
                    else if (temp == 2)
                    {
                        //Choisit aléatoirement un caractère maj alphabétique
                        char caracter = Convert.ToChar(rnd.Next(65, 91));
                        tab_chrNewMdp[x] = caracter;
                    }
                    else
                    {
                        //Choisit aléatoirement un caractère min alphabétique
                        char caracter = Convert.ToChar(rnd.Next(97, 122));
                        tab_chrNewMdp[x] = caracter;
                    }
                }
                //Noveau mot de passe
                string newMdp = new string(tab_chrNewMdp);
                //Mail de l'expéditeur
                string strExpediteur = "garouloup426@gmail.com";
                //Texte du mail
                string strTexte = "Voici le nouveau mot de passe de votre compte: " + newMdp;
                //Stok les inoformations dans l'ordre le mail de l'expédieteur, puis le mail de récépteur, le sujet du mail et le texte du mail
                MailMessage email = new MailMessage(strExpediteur, mailTo, "Recuperation de compte", strTexte);
                //Information personnel du compte
                NetworkCredential cred = new NetworkCredential(strExpediteur, "LoupGarou-426");
                email.IsBodyHtml = true;
                //MOdifie la priorité du mail
                email.Priority = MailPriority.High;
                smtp.Credentials = cred;

                string userState = "Message";
                try
                {
                    //Envoi du mail s
                    smtp.SendAsync(email, userState);
                    return newMdp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return newMdp;
                }
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message);
                return "A";
            }
        }
        /// <summary>
        /// Je sais pas ce que ça fait, le code viens de https://codes-sources.commentcamarche.net/source/48115-send-mail-with-gmail
        /// </summary>
        public void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;
        }
    }
}
