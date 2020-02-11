///ETML
///Auteur : Brunner Théo
///Date : 11.02.2020
///Description : Interface du loup garou pour le plateau de jeux
///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ViewPlayerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /**Taille minimum de la fenetre */
            this.MinimumSize = new Size(800, 600);
            /**Ajout un quar des joueur sur le trait du haut*/
            for(int i = 0; i< NBPLAYER/4 ;i++)
            {
                /**Verifie si l'on a dépassé le nombre de joeuer qui exite*/
                if(!(compteur>=NBPLAYER))
                {
                    CreatePlayerTrait(PostionStartTraitX, PostionStartTraitY, "PictureBox" + Convert.ToString(i));
                }
                compteur++;
            }
            /**Remets la valeur à la valeur initial*/
            PostionStartTraitX = 175;
            for (int i = 0; i < (NBPLAYER / 4); i++)
            {
                /**Verifie si l'on a dépassé le nombre de joeuer qui exite*/
                if (!(compteur >= NBPLAYER))
                {
                    CreatePlayerTrait(PostionStartTraitX, PostionStartTraitY + 360, "PictureBox" + Convert.ToString(i));
                }
                compteur++;
            }
            /**Cree tous les joueur sur les lignes*/
            ArcPLayer(ref players2);
        }
        private int PostionStartTraitX = 175;/**Postion de départ sur l'axe x (longeur)  des picture box sur les traits*/
        private int PostionStartTraitY = 60;/**Postion de départ sur l'axe y (hauteur)  des picture box sur les traits*/
        private byte compteur = 0;/**Compte le nombre de picture box créer*/
        List<PictureBox> players1 = new List<PictureBox>();/**Joueur sur les traits droits*/
        List<PictureBox> players2 = new List<PictureBox>();/**Joueur sur les arc de cercle*/
        private decimal NBPLAYER = 7;/**Nombre de joeur total*/
        private bool fullScreen = false;/**Verifie si on est en pleine écran*/
        /// <summary>
        /// Quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Mets en plein ecran ou reduit la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgrandir_Click(object sender, EventArgs e)
        {
            /**Verifie si on est en plein écran ou non*/
            if(fullScreen)
            {
                fullScreen = false;
                /**Change le fond du boutton*/
                btnAgrandir.BackgroundImage = Properties.Resources.FullScreen;
                //Reduit la fenetre
                WindowState = FormWindowState.Normal;
            }
            else
            {
                fullScreen = true;
                /**Affichage en plein écran de la fenetre*/
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                /**Change le fond du boutton*/
                btnAgrandir.BackgroundImage = Properties.Resources.Minimize;
            }
        }
        /// <summary>
        /// Reduit la fenetre au minimum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrierrePlan_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /**Change la taille des éléments*/
            pibLogo.Height = (Size.Height) / 20;
            pibLogo.Width = (Size.Width) / 29;
            btnAgrandir.Height = (Size.Height) / 20;
            btnAgrandir.Width = (Size.Width) / 29;
            btnArrierrePlan.Height = (Size.Height) / 20;
            btnArrierrePlan.Width = Convert.ToInt32((Size.Width) / 26);
            btnExit.Height = (Size.Height) / 20;
            btnExit.Width = (Size.Width) / 29;
            pnlGame.Width = Convert.ToInt32((Size.Width) / 1.5);
            pnlGame.Height = Convert.ToInt32((Size.Height) / 1.2);
            txbMessage.Width = Convert.ToInt32((Size.Width) / 3.8);
            rtbMessage.Width = Convert.ToInt32((Size.Width) / 3.8);
            rtbMessage.Height = Convert.ToInt32((Size.Height) / 1.25);
            btnMenu.Width = Convert.ToInt32((Size.Width) / 13.92);
            btnMenu.Height = Convert.ToInt32((Size.Height) / 21);
            /**Change la postion des éléments*/
            btnArrierrePlan.Location = new Point(Convert.ToInt32((Size.Width) / 1.15), Convert.ToInt32(18));
            btnAgrandir.Location = new Point(Convert.ToInt32((Size.Width) / 1.09), Convert.ToInt32(15));
            btnExit.Location = new Point(Convert.ToInt32((Size.Width) / 1.045045), Convert.ToInt32(15));
            pnlGame.Location = new Point(13, Convert.ToInt32((Size.Height) / 9.81));
            btnMenu.Location = new Point(13, Convert.ToInt32((Size.Height) / 1.065));
            rtbMessage.Location = new Point(Convert.ToInt32((Size.Width) / 1.45), Convert.ToInt32((Size.Height) / 9.81));
            txbMessage.Location = new Point(Convert.ToInt32((Size.Width) / 1.45), Convert.ToInt32((Size.Height) / 1.1034));
            /**Verifie si l'on est en plein écran*/
            if (fullScreen)
            {
                /**Change la taille de la police de la textbox et richtextboxs*/
                rtbMessage.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txbMessage.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnMenu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                /**Change la taille de la police de la textbox et richtextboxs*/
                rtbMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txbMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
        }
        #region Mise à jour des positions des objets de la fenêtre
        public const byte CGRIP = 32;
        public const byte CCAPTION = 32;
        /// <summary>
        /// Création du rectangle et du Grip
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - CGRIP, ClientSize.Height - CGRIP, CGRIP, CGRIP);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
            Brush brush = new SolidBrush(Color.Transparent);
            rc = new Rectangle(0, 0, ClientSize.Width, CCAPTION);
            e.Graphics.FillRectangle(brush, rc);
        }

        /// <summary>
        /// Mise à jour des positions 
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < CCAPTION)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= ClientSize.Width - CGRIP && pos.Y >= ClientSize.Height - CGRIP)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion
        /// <summary>
        /// Change la couleur de fond si on quitte le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Transparent;
        }
        /// <summary>
        /// Change la couleur de fond si on rentre dans la zone le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }
        /// <summary>
        /// Envoi le message dans le chat lorsque l'utilisateur clique sur entrer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteInChat(object sender, KeyPressEventArgs e)
        {
            /**Verifie si l'utlisateur à appuyez sur entrer*/
            if(e.KeyChar == '\r')
            {
                TextBox txt = sender as TextBox;
                /**Envoi le message dans rtbMessage*/
                rtbMessage.AppendText(txt.Text);
            }
        }
        /// <summary>
        /// Methode de création des joueurs sur les deux traits
        /// </summary>
        /// <param name="PostionX">Postion sur l'hoizontal de la picture box</param>
        /// <param name="PostionY">Postion sur la vertical de la picture box</param>
        /// <param name="namePlayer">Nom de la picture box</param>
        public void CreatePlayerTrait(int PostionX, int PostionY, string namePlayer)
        {
            PictureBox pictureBox;/**Picture box du joueur*/
            pictureBox = new PictureBox();
            /**Ajout la picture box dans le panel*/
            pnlGame.Controls.Add(pictureBox);
            /**Création de la picture box avec toutes les informations utlile*/
            ((ISupportInitialize)(pictureBox)).BeginInit();
            pictureBox.BackgroundImage = Properties.Resources.Player;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Location = new Point(PostionX, PostionY);
            pictureBox.Name = namePlayer;
            pictureBox.Size = new Size(40, 40);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            /**Ajout la picture box dans la liste*/
            players1.Add(pictureBox);
            /**Calcul le septieme d nombre de joueur*/
            int quart = Convert.ToInt32((NBPLAYER / 7));
            /**Ajout l'écart entre des personnes*/
            PostionStartTraitX += 200 / quart+10;
        }
        /// <summary>
        /// Methode de création des joueurs sur les deux arcs
        /// </summary>
        /// <param name="players">Liste des joueur sur les arcs</param>
        public void ArcPLayer(ref List<PictureBox> players)
        {
            int radius = 100;/**Radius de base*/
            /**Boucle d'ajout dans la liste de toutes les pictures box*/
            for (int i = 0;i<NBPLAYER-players1.Count();i++)
            { 
                players.Add(new PictureBox());
            }
            /**Boucle de postionnement et d'ajout des informations de toutes les pcitures box*/
            for (int i = 0; i < players.Count(); i++)
            {
                /**Angle de la picture box dans le cercle*/
                double angle = 360f / ((float)players.Count()) * ((float)i);
                angle = Math.PI * angle / 180f;
                /**Limit entre les deux demi cercles*/
                double limitAngle = Math.PI / 2d;
                /**Verifie si l'on n'est sur le permiers ou deuxieme demi cercle*/
                if (angle > limitAngle && angle < limitAngle + Math.PI)
                    /**Postionment de la picture box*/
                    players[i].Location = new Point((int)(Math.Cos(angle)* radius) + 125, ((int)(Math.Sin(angle) * radius*1.55)+ 230 ));
                else
                    /**Postionment de la picture box*/
                    players[i].Location = new Point((int)(Math.Cos(angle) * radius) + 525,((int)(Math.Sin(angle) * radius * 1.55) + 230 ));
                /**Ajout la picture box dans le panel*/
                pnlGame.Controls.Add(players[i]);
                /**Ajout des info utlile de la picture box*/
                ((ISupportInitialize)(players[i])).BeginInit();
                players[i].BackgroundImage = Properties.Resources.Player;
                players[i].BackgroundImageLayout = ImageLayout.Zoom;
                players[i].Size = new Size(40, 40);
                players[i].TabIndex = 1;
                players[i].TabStop = false;
            }
        }
    }
}
