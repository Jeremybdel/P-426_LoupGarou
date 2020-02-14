namespace chat
{
    partial class chatUC
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstbMessages = new System.Windows.Forms.ListBox();
            this.ctms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctms.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbInput
            // 
            this.txtbInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.txtbInput.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbInput.ForeColor = System.Drawing.Color.White;
            this.txtbInput.Location = new System.Drawing.Point(3, 461);
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(259, 31);
            this.txtbInput.TabIndex = 0;
            this.txtbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbInput_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(268, 461);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 30);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstbMessages
            // 
            this.lstbMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.lstbMessages.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbMessages.ForeColor = System.Drawing.Color.White;
            this.lstbMessages.FormattingEnabled = true;
            this.lstbMessages.ItemHeight = 16;
            this.lstbMessages.Location = new System.Drawing.Point(3, 3);
            this.lstbMessages.Name = "lstbMessages";
            this.lstbMessages.Size = new System.Drawing.Size(326, 452);
            this.lstbMessages.TabIndex = 2;
            this.lstbMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstbMessages_MouseClick);
            this.lstbMessages.DoubleClick += new System.EventHandler(this.lstbMessages_DoubleClick);
            // 
            // ctms
            // 
            this.ctms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ctms.Name = "ctms";
            this.ctms.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(78)))), ((int)(((byte)(84)))));
            this.Controls.Add(this.lstbMessages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtbInput);
            this.Name = "chatUC";
            this.Size = new System.Drawing.Size(332, 497);
            this.ctms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstbMessages;
        private System.Windows.Forms.ContextMenuStrip ctms;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
