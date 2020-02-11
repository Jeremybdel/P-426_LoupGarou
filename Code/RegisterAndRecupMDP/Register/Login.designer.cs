using System;

namespace Werewolf.Views
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txt_EmailConnect = new System.Windows.Forms.TextBox();
            this.txt_PasswordConnect = new System.Windows.Forms.TextBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(12, 66);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(135, 23);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Pseudo / Email :";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(135, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe   :";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(219, 198);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.bConnection_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(12, 198);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Inscription";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // txt_EmailConnect
            // 
            this.txt_EmailConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_EmailConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmailConnect.Location = new System.Drawing.Point(153, 70);
            this.txt_EmailConnect.Name = "txt_EmailConnect";
            this.txt_EmailConnect.Size = new System.Drawing.Size(141, 20);
            this.txt_EmailConnect.TabIndex = 5;
            this.txt_EmailConnect.TextChanged += new System.EventHandler(this.txt_EmailConnect_TextChanged);
            this.txt_EmailConnect.GotFocus += new System.EventHandler(this.tbLogin_GotFocus);
            // 
            // txt_PasswordConnect
            // 
            this.txt_PasswordConnect.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_PasswordConnect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PasswordConnect.Location = new System.Drawing.Point(153, 126);
            this.txt_PasswordConnect.Name = "txt_PasswordConnect";
            this.txt_PasswordConnect.Size = new System.Drawing.Size(141, 20);
            this.txt_PasswordConnect.TabIndex = 6;
            this.txt_PasswordConnect.GotFocus += new System.EventHandler(this.tbPassword_GotFocus);
            // 
            // lblConnection
            // 
            this.lblConnection.Font = new System.Drawing.Font("Calibri Light", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblConnection.Location = new System.Drawing.Point(92, 9);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(123, 23);
            this.lblConnection.TabIndex = 7;
            this.lblConnection.Text = "Connexion";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(285, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(306, 233);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.txt_PasswordConnect);
            this.Controls.Add(this.txt_EmailConnect);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txt_EmailConnect;
        private System.Windows.Forms.TextBox txt_PasswordConnect;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblExit;
    }
}

