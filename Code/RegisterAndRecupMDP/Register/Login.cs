using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Werewolf.Views
{
    public partial class Login : Form
    {
        bool tbLoginFocused = true;
        bool tbPasswordFocused = true;
        Model model = new Model();
        public Login()
        {
            InitializeComponent();
        }
        private void tbLogin_GotFocus(object sender, EventArgs e)
        {
            if (tbLoginFocused)
            {
                txt_EmailConnect.ResetText();
                tbLoginFocused = false;
            }

        }

        private void tbPassword_GotFocus(object sender, EventArgs e)
        {
            if (tbPasswordFocused)
            {
                txt_PasswordConnect.ResetText();
                tbPasswordFocused = false;
            }
            txt_PasswordConnect.UseSystemPasswordChar = true;
        }

        private void bConnection_Click(object sender, EventArgs e)
        {
            if (model.TryConnectUserMail(txt_EmailConnect.Text, txt_PasswordConnect.Text))
            {
                Form1 frm = new Form1(model);
                frm.Show();
                this.Visible = false;
            }
            else if (model.TryConnectUserPseudo(txt_EmailConnect.Text, txt_PasswordConnect.Text))
            {
                Form1 frm = new Form1(model);
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Les indentifiants entrés sont incorrects");
            }

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();

            Hide();
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_EmailConnect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
