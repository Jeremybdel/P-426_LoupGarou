///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base permettant d'envoyer un mail avec un mot de passe aléatoire
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvoiDeMailDeRecuperation
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
