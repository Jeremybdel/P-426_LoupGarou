using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Werewolf.Views
{
    public partial class Register : Form
    {
        private bool gotFocusedSurname = true;
        private bool gotFocusedName = true;
        private bool gotFocusedEmail = true;
        private bool gotFocusedPassword = true;
        private bool gotFocusedConfirmation = true;
        private Login login;
        Model model = new Model();
        public Register(Login login)
        {
            InitializeComponent();
            this.login = login;

        }
        private void tbSurname_GotFocus(object sender, EventArgs e)
        {
            if (gotFocusedSurname)
            {
                gotFocusedSurname = false;
            }
        }
        private void tbName_GotFocus(object sender, EventArgs e)
        {
            if (gotFocusedName)
            {
                txtNickname.ResetText();
                gotFocusedName = false;
            }
        }
        private void tbEmail_GotFocus(object sender, EventArgs e)
        {
            if (gotFocusedEmail)
            {
                txt_email.ResetText();
                gotFocusedEmail = false;
            }
        }
        private void tbPassword_GotFocus(object sender, EventArgs e)
        {
            if (gotFocusedPassword)
            {
                txt_password.ResetText();
                gotFocusedPassword = false;
            }
            txt_password.UseSystemPasswordChar = true;
        }
        private void tbConfirmation_GotFocus(object sender, EventArgs e)
        {
            if (gotFocusedConfirmation)
            {
                txt_password2.ResetText();
                gotFocusedConfirmation = false;
            }
            txt_password2.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text != "" && txt_email.Text != "" && txt_password.Text != "" && txt_password2.Text != "")
            {
                if (txt_password.Text == txt_password2.Text)
                {
                    if (Regex.IsMatch(txtNickname.Text, model.REGEX_NICKNAME))
                    {
                        if (Regex.IsMatch(txt_email.Text, model.RegexEmail))
                        {
                            if (Regex.IsMatch(txt_password.Text, model.RegexPassword))
                            {
                                model.InsertUser(txtNickname.Text.ToLower(), txt_email.Text.ToLower(), model.DisplayHashCode(txt_password.Text).ToString(), new byte[0]);
                                txt_email.Clear();
                                txt_password.Clear();
                                txt_password2.Clear();
                                txtNickname.Clear();
                                MessageBox.Show("Votre compte a été crée avec succès!");
                                btnConnection_Click(null, null);

                            }
                            else
                            {
                                MessageBox.Show("Merci d'entrer un mot de passe valide.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Merci d'entrer une adresse email valide !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Merci d'entrer un pseudo valide !");
                    }
                }
                else
                {
                    MessageBox.Show("Merci d'entrer 2 fois le même mot de passe.");
                }
            }
            else
            {
                MessageBox.Show("Merci de remplir tous le champs !");
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            Close();
            login.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.LightGray;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Transparent;
        }

        private void lblInscription_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
