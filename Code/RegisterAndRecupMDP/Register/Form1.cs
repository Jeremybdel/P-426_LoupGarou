///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base permettant d'envoyer un mail avec un mot de passe aléatoire
///
using System;
using System.Windows.Forms;

namespace Werewolf.Views
{
    public partial class Form1 : Form
    {
        //Classe d'envoi du mail 
        private SendMail send = new SendMail();
        private Model model;
        /// <summary>
        /// 
        /// </summary>
        public Form1(Model _model)
        {
            InitializeComponent();
            send.Connexion();
            model = _model;
        }
        /// <summary>
        /// Envoi du mail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string newMDP = send.MailSend(txbMailTo.Text);
            model.TryUpdateMDP(newMDP);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbMailTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
