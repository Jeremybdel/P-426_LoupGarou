///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base sans la connection au compte pour modifier les comptes
///
using System;
using System.Windows.Forms;

namespace ModifAccount
{
    public partial class ModifAccount : Form
    {
        public ModifAccount()
        {
            InitializeComponent();
        }
        private string emplcementBase = Application.StartupPath;//Emplacement de l'application
        private string chemin;//Chemin de la photo de profil
        /// <summary>
        /// Permet de modifier la photo de profil, code provenant de https://www.commentcamarche.net/forum/affich-6520182-importer-une-image-en-c
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();//Création d'une fenetre d'exploration
            f.InitialDirectory = emplcementBase+ @"\PhotoDeProfil";//Emplacement de base de l'openfiledialog est le dossier des photos de profil
            f.ShowDialog(); //Affichage de cette fenetre
            chemin = f.FileName; //On récupère l'adresse de l'image qu'on affecte à la varaiable chemin (string)
            pibAvatar.ImageLocation = chemin;//Modifie l'image 
        }

        private void ModifAccount_Load(object sender, EventArgs e)
        {

        }
    }
}