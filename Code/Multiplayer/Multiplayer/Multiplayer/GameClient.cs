/*
 * Auteur : Arthur Menétrey, Tristan Gerber
 * Date : 17.01.2020
 * Description : Ce programme consiste à créer un loup-garou en multijoueur.
 * 
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Werewolf.Resources;
using static Werewolf.Resources.Library.CommandList;

namespace Werewolf.Multiplayer
{
    /// <summary>
    /// Cette classe gère la connexion entre le client et l'hôte.
    /// </summary>
    class GameClient
    {
        #region Déclaration des données
        private String server;
        private String message;
        private Int32 port = 13000;
        private TcpClient client;
        private NetworkStream stream;
        private IPAddress localAddr = IPAddress.Parse(GetLocalIPAddress());
        private bool connected = false;
        private Thread clientThread;
        #endregion

        #region Events handlers
        public delegate void Handler();

        public event Handler Connected;
        public event Handler Disconnected;
        public event Handler Error;
        #endregion

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="server">adresse du serveur</param>
        /// <param name="port">port du serveur</param>
        public GameClient(string server, int port)
        {
            this.server = server;
            this.port = port;
        }

        /// <summary>
        /// Démmare le serveur
        /// </summary>
        public bool Start()
        {
            try
            {
                client = new TcpClient(server, port);
                stream = client.GetStream();
                SendMessage(CONNECT + ENDTYPE + DATASIGN + localAddr + ENDDATASIGN + ENDCOMMAND, true);

                clientThread = new Thread(new ThreadStart(Listen));
                clientThread.Start();
            }
            catch { return false; }

            return true;
        }

        public void Stop()
        {
            SendMessage(DISCONNECT + ENDTYPE + ENDCOMMAND);
            clientThread.Abort();
        }

        /// <summary>
        /// Méthode de démarrage du client
        /// </summary>
        public void Listen()
        {
            try
            {
                byte[] bytes = new Byte[256];

                SendMessage(CONNECT + ENDTYPE + DATASIGN + localAddr + ENDDATASIGN + ENDCOMMAND);

                while (true)
                {
                    int i;

                    try
                    {
                        if ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            RequestDealer(Tuple.Create(Encoding.ASCII.GetString(bytes, 0, bytes.Length), stream));
                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Une erreur de connection est survenue");
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("Une erreur de connection est survenue"); }
        }

        /// <summary>
        /// On définit et exécute les requêtes du client
        /// </summary>
        /// <param name="request"></param>
        private void RequestDealer(object o)
        {
            long startTime = DateTime.Now.Ticks;

            #region Transform request data
            Tuple<string, NetworkStream> data = (Tuple<string, NetworkStream>)o;

            if (data.Item1.Length != 0)
            {
                string request = data.Item1.Substring(0, data.Item1.IndexOf((char)0));

                if (data.Item1.IndexOf(ENDTYPE) != -1 && data.Item1.IndexOf(ENDCOMMAND) != -1)
                {
                    string commandType = request.Substring(0, request.IndexOf(ENDTYPE));
                    NetworkStream stream = data.Item2;
                    List<string> parameters = new List<string>();

                    if (data.Item1.IndexOf(DATASIGN) != -1)
                    {
                        string tempRequest = data.Item1;

                        while (request.IndexOf(DATASIGN) != -1)
                        {
                            parameters.Add(tempRequest.Substring(tempRequest.IndexOf(DATASIGN), ENDDATASIGN));
                            tempRequest = tempRequest.Substring(0, tempRequest.IndexOf(DATASIGN)) + tempRequest.Substring(0, tempRequest.IndexOf(ENDDATASIGN));
                        }
                    }
            #endregion

                    switch (commandType)
                    {
                        #region Disconnect
                        case DISCONNECT:
                            connected = false;
                            Disconnected?.Invoke();
                            break;
                        #endregion
                        #region Connected
                        case CONNECTED:
                            connected = true;
                            Connected?.Invoke();
                            break;
                        #endregion
                        #region Doesn't exist
                        default:
                            SendMessage(ERROR + ENDTYPE + ENDCOMMAND);
                            Error?.Invoke();
                            break;
                        #endregion
                    }
                }
            }
        }

        /// <summary>
        /// Envoie des données a un client (un message)
        /// </summary>
        /// <param name="Commmand"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool SendMessage(string command, bool force = false)
        {
            if (connected || force )
            {
                try
                {
                    stream.Write(GetBytes(command), 0, command.Length);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Méthode retournant l'adresse ip locale
        /// </summary>
        /// <returns></returns>
        private static string GetLocalIPAddress()
    {
        // On récupère la liste d'adresses ip du pc, et lorsqu'on trouve l'adresse IPv4, on la retourne.
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }

        /// <summary>
        /// Retourne un texte converti en byte
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private byte[] GetBytes(string text)
        {
            return Encoding.ASCII.GetBytes(text);
        }
    }
}