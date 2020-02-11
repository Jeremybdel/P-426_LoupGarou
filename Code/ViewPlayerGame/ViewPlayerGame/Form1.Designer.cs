namespace ViewPlayerGame
{
    partial class Form1
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnArrierrePlan = new System.Windows.Forms.Button();
            this.btnAgrandir = new System.Windows.Forms.Button();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlGame.Location = new System.Drawing.Point(13, 64);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(742, 515);
            this.pnlGame.TabIndex = 2;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(761, 559);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(271, 20);
            this.txbMessage.TabIndex = 3;
            this.txbMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WriteInChat);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(762, 64);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(270, 489);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "asdsdasd";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(13, 586);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 30);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::ViewPlayerGame.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(996, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnArrierrePlan
            // 
            this.btnArrierrePlan.BackColor = System.Drawing.Color.Transparent;
            this.btnArrierrePlan.BackgroundImage = global::ViewPlayerGame.Properties.Resources.ArrierePlan;
            this.btnArrierrePlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArrierrePlan.FlatAppearance.BorderSize = 0;
            this.btnArrierrePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrierrePlan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArrierrePlan.Location = new System.Drawing.Point(911, 15);
            this.btnArrierrePlan.Name = "btnArrierrePlan";
            this.btnArrierrePlan.Size = new System.Drawing.Size(36, 33);
            this.btnArrierrePlan.TabIndex = 6;
            this.btnArrierrePlan.UseVisualStyleBackColor = false;
            this.btnArrierrePlan.Click += new System.EventHandler(this.btnArrierrePlan_Click);
            this.btnArrierrePlan.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnArrierrePlan.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // btnAgrandir
            // 
            this.btnAgrandir.BackColor = System.Drawing.Color.Transparent;
            this.btnAgrandir.BackgroundImage = global::ViewPlayerGame.Properties.Resources.FullScreen;
            this.btnAgrandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgrandir.FlatAppearance.BorderSize = 0;
            this.btnAgrandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrandir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgrandir.Location = new System.Drawing.Point(954, 12);
            this.btnAgrandir.Name = "btnAgrandir";
            this.btnAgrandir.Size = new System.Drawing.Size(36, 35);
            this.btnAgrandir.TabIndex = 5;
            this.btnAgrandir.UseVisualStyleBackColor = false;
            this.btnAgrandir.Click += new System.EventHandler(this.btnAgrandir_Click);
            this.btnAgrandir.MouseEnter += new System.EventHandler(this.btnEnter);
            this.btnAgrandir.MouseLeave += new System.EventHandler(this.btnLeave);
            // 
            // pibLogo
            // 
            this.pibLogo.BackColor = System.Drawing.Color.Transparent;
            this.pibLogo.BackgroundImage = global::ViewPlayerGame.Properties.Resources.Trait;
            this.pibLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibLogo.Location = new System.Drawing.Point(12, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(42, 36);
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 628);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnArrierrePlan);
            this.Controls.Add(this.btnAgrandir);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pibLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnAgrandir;
        private System.Windows.Forms.Button btnArrierrePlan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMenu;
    }
}

