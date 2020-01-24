///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base permettant d'envoyer un mail avec un mot de passe aléatoire
///
using System;
using System.Windows.Forms;

namespace EnvoiDeMailDeRecuperation
{
    public partial class Form1 : Form
    {
        //Classe d'envoi du mail 
        SendMail send = new SendMail();
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            send.Connexion();
        }
        /// <summary>
        /// Envoi du mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            send.MailSend(txbMailTo.Text);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbMailTo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
