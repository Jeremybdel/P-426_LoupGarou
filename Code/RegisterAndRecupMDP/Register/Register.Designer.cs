namespace Werewolf.Views
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInscription = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInscription
            // 
            this.lblInscription.Font = new System.Drawing.Font("Calibri Light", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblInscription.Location = new System.Drawing.Point(85, 31);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(123, 23);
            this.lblInscription.TabIndex = 8;
            this.lblInscription.Text = "Inscription";
            this.lblInscription.Click += new System.EventHandler(this.lblInscription_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(153, 185);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(141, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.GotFocus += new System.EventHandler(this.tbPassword_GotFocus);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(135, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Location = new System.Drawing.Point(153, 143);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(141, 20);
            this.txt_email.TabIndex = 3;
            this.txt_email.GotFocus += new System.EventHandler(this.tbEmail_GotFocus);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(85, 23);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNickname.Location = new System.Drawing.Point(153, 106);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(141, 20);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.GotFocus += new System.EventHandler(this.tbName_GotFocus);
            // 
            // lblNickname
            // 
            this.lblNickname.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname.Location = new System.Drawing.Point(12, 102);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(85, 23);
            this.lblNickname.TabIndex = 13;
            this.lblNickname.Text = "Pseudo";
            // 
            // txt_password2
            // 
            this.txt_password2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password2.Location = new System.Drawing.Point(153, 230);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(141, 20);
            this.txt_password2.TabIndex = 5;
            this.txt_password2.GotFocus += new System.EventHandler(this.tbConfirmation_GotFocus);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(12, 226);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(135, 23);
            this.lblConfirmation.TabIndex = 15;
            this.lblConfirmation.Text = "Confirmation :";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(219, 292);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Confirmer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(16, 292);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 7;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(286, -1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(306, 327);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblExit;
    }
}