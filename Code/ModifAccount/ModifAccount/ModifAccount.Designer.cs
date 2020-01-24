namespace ModifAccount
{
    partial class ModifAccount
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.txbMDP = new System.Windows.Forms.TextBox();
            this.txbPseudo = new System.Windows.Forms.TextBox();
            this.lblMailAccount = new System.Windows.Forms.Label();
            this.pibAvatar = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.btnModifAvatar = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(65, 60);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(72, 13);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Adresse mail: ";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(65, 152);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(77, 13);
            this.lblMDP.TabIndex = 1;
            this.lblMDP.Text = "Mot de passe: ";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(65, 104);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(49, 13);
            this.lblPseudo.TabIndex = 2;
            this.lblPseudo.Text = "Pseudo: ";
            // 
            // txbMDP
            // 
            this.txbMDP.Location = new System.Drawing.Point(202, 145);
            this.txbMDP.Name = "txbMDP";
            this.txbMDP.PasswordChar = '*';
            this.txbMDP.Size = new System.Drawing.Size(226, 20);
            this.txbMDP.TabIndex = 3;
            // 
            // txbPseudo
            // 
            this.txbPseudo.Location = new System.Drawing.Point(202, 97);
            this.txbPseudo.Name = "txbPseudo";
            this.txbPseudo.PasswordChar = '*';
            this.txbPseudo.Size = new System.Drawing.Size(226, 20);
            this.txbPseudo.TabIndex = 4;
            // 
            // lblMailAccount
            // 
            this.lblMailAccount.AutoSize = true;
            this.lblMailAccount.Location = new System.Drawing.Point(208, 60);
            this.lblMailAccount.Name = "lblMailAccount";
            this.lblMailAccount.Size = new System.Drawing.Size(26, 13);
            this.lblMailAccount.TabIndex = 5;
            this.lblMailAccount.Text = "Mail";
            // 
            // pibAvatar
            // 
            this.pibAvatar.Location = new System.Drawing.Point(202, 197);
            this.pibAvatar.Name = "pibAvatar";
            this.pibAvatar.Size = new System.Drawing.Size(226, 113);
            this.pibAvatar.TabIndex = 6;
            this.pibAvatar.TabStop = false;
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.Location = new System.Drawing.Point(65, 197);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(81, 13);
            this.lblAvatar.TabIndex = 7;
            this.lblAvatar.Text = "Photo de profil: ";
            // 
            // btnModifAvatar
            // 
            this.btnModifAvatar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnModifAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifAvatar.ForeColor = System.Drawing.Color.Red;
            this.btnModifAvatar.Location = new System.Drawing.Point(202, 316);
            this.btnModifAvatar.Name = "btnModifAvatar";
            this.btnModifAvatar.Size = new System.Drawing.Size(137, 23);
            this.btnModifAvatar.TabIndex = 8;
            this.btnModifAvatar.Text = "Modifier la photo de profil";
            this.btnModifAvatar.UseVisualStyleBackColor = false;
            this.btnModifAvatar.Click += new System.EventHandler(this.btnModifAvatar_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.BurlyWood;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.Color.Red;
            this.btnModifier.Location = new System.Drawing.Point(164, 386);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 39);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier les informations du compte";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // ModifAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnModifAvatar);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.pibAvatar);
            this.Controls.Add(this.lblMailAccount);
            this.Controls.Add(this.txbPseudo);
            this.Controls.Add(this.txbMDP);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblMail);
            this.Name = "ModifAccount";
            this.Text = "Modification de compte";
            this.Load += new System.EventHandler(this.ModifAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.TextBox txbMDP;
        private System.Windows.Forms.TextBox txbPseudo;
        private System.Windows.Forms.Label lblMailAccount;
        private System.Windows.Forms.PictureBox pibAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Button btnModifAvatar;
        private System.Windows.Forms.Button btnModifier;
    }
}

