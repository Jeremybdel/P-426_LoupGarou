using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Werewolf.Resources;

namespace chat
{
    public partial class chatUC : UserControl
    {
        public chatUC()
        {
            InitializeComponent();
            this.lstbMessages.ContextMenuStrip = ctms;
        }

        Player p = new Player("xXMarcraftXx", System.Net.IPAddress.Any, null);
        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {              
                if ((!txtbInput.Text.StartsWith(" ") || !txtbInput.Text.EndsWith(" ")) && txtbInput.Text != "" && !txtbInput.Text.Contains(" "))            
                {
                    Message msg = new Message(txtbInput.Text, p);
                    lstbMessages.Items.Add(msg.Sender.Nickname + " : " + msg.Msg);
                    txtbInput.ResetText();
                }
                txtbInput.ResetText();

            }
            catch (Exception ex)
            {

            }
        }

        private void txtbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender,e);
            }
        }

        private void lstbMessages_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void lstbMessages_DoubleClick(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstbMessages.Items.Remove(lstbMessages.SelectedItem);

        }
    }
}
