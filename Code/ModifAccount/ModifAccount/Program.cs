///ETML
///Auteur : Brunner Théo
///Date : 21.1.2020
///Description : Programme de base sans la connection au compte pour modifier les comptes
///
using System;
using System.Windows.Forms;

namespace ModifAccount
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
            Application.Run(new ModifAccount());
        }
    }
}
