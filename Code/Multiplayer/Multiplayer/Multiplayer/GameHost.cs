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
using Werewolf.Resources;
using System.Threading;
using static Werewolf.Resources.Library.CommandList;
using System.Windows.Forms;

namespace Werewolf.Multiplayer
{
    /// <summary>
    /// Cette classe gère la connexion entre tous les clients et fais en sorte qu'ils rejoignent la partie.
    /// </summary>
    class GameHost
    {
        #region Déclaration des données

        private HashSet<IPAddress> clientsIp = new HashSet<IPAddress>(); // Liste des clients qui sont connectés
        private HashSet<IPAddress> lostClientsIp = new HashSet<IPAddress>(); // Liste des clients qui sont déconnectés

        private TcpListener server; // PC qui host
        private Int32 port = 13001; // Port qui sera utilisé pour se connecter
        private IPAddress localAddr = IPAddress.Parse(GetLocalIPAddress()); // Addresse ip du PC qui host

        private static int connectedClientTestElapsed = 5000;
        private static System.Timers.Timer connectedClientTimer = new System.Timers.Timer(connectedClientTestElapsed); // Vérifie si il y a une connection toutes les x millisecondes

        private Byte[] bytes = new Byte[256]; // Tableau qui contiendra les données

        private Thread serverThread;

        private bool debugMode;
        #endregion Déclaration des données

        /// <summary>
        /// Constructeur du game host
        /// </summary>
        /// <param name="debugMode">debug mode</param>
        public GameHost(bool debugMode = false)
        {
            this.debugMode = debugMode;

            if (debugMode)
                Console.WriteLine("Server Initialized !\nIP = {0}, Port = {1}",localAddr,port);
        }

        /// <summary>
        /// Démmare le serveur
        /// </summary>
        public void Start()
        {
            serverThread = new Thread(new ThreadStart(Listen));
            serverThread.Start();

            if (debugMode)
                Console.WriteLine("Le serveur à démmaré correctement");
        }

        /// <summary>
        /// Arrete le serveur
        /// </summary>
        public void Stop()
        {
            BroadCast(Library.CommandList.DISCONNECT);
            serverThread.Abort();
        }

        /// <summary>
        /// Méthode principale, exécutée au début, qui se charge de récupérer les données du client
        /// </summary>
        private void Listen()
        {
            NetworkStream stream; // Permet de communiquer avec le client

            TcpClient client; // Client avec qui on va communiquer

            Console.WriteLine("Listening\n");
            // On démarre la recherche de clients
            server = new TcpListener(localAddr, port);
            server.Start();

            while (true)
            {
                // On prend le premier client qu'on trouve
                client = server.AcceptTcpClient();

                // On écoute le client
                stream = client.GetStream();

                int i;

                // On lis les requêtes du client
                try
                {
                    if ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        //ThreadPool.QueueUserWorkItem(RequestDealer, Tuple.Create(Encoding.ASCII.GetString(bytes, 0, bytes.Length), client));
                        RequestDealer(Tuple.Create(Encoding.ASCII.GetString(bytes, 0, bytes.Length), client));
                    }
                }
                catch (System.IO.IOException) { }

                // On ferme la connection et on recommence
                client.Close();
            }
        }

        /// <summary>
        /// On définit et exécute les requêtes du client
        /// </summary>
        /// <param name="request"></param>
        private void RequestDealer(object o)
        {
            try
            {
                long startTime = DateTime.Now.Millisecond;

                #region Transform request data
                Tuple<string, TcpClient> data = (Tuple<string, TcpClient>)o;

                if (data.Item1.Length != 0)
                {
                    string request = data.Item1.Substring(0, data.Item1.IndexOf((char)0));

                    if (debugMode)
                        Console.Write(DateTime.Now.ToString() + "> " + request);

                    if (data.Item1.IndexOf(ENDTYPE) != -1 && data.Item1.IndexOf(ENDCOMMAND) != -1)
                    {
                        string commandType = request.Substring(0, request.IndexOf(ENDTYPE));
                        TcpClient client = data.Item2;
                        IPAddress clientIP = IPAddress.Parse(client.Client.LocalEndPoint.ToString().Substring(0, client.Client.LocalEndPoint.ToString().IndexOf(":")));
                        NetworkStream stream = client.GetStream();
                        List<string> parameters = new List<string>();

                        if (data.Item1.IndexOf(DATASIGN) != -1)
                        {
                            string tempRequest = data.Item1.Substring(0, data.Item1.IndexOf(ENDCOMMAND) + 1);

                            while (tempRequest.IndexOf(DATASIGN) != -1)
                            {
                                parameters.Add(tempRequest.Substring(tempRequest.IndexOf(DATASIGN) + 1, tempRequest.IndexOf(ENDDATASIGN) - tempRequest.IndexOf(DATASIGN) - 1));
                                tempRequest = tempRequest.Substring(tempRequest.IndexOf(ENDDATASIGN) + 1, tempRequest.Length - tempRequest.IndexOf(ENDDATASIGN) - 1);
                            }
                        }
                #endregion

                        switch (commandType)
                        {
                            #region Disconnect
                            case DISCONNECT:
                                try
                                {
                                    RemoveClient(clientIP);
                                    SendMessage(DISCONNECT + ENDTYPE + ENDCOMMAND, client);
                                }
                                catch { }
                                break;
                            #endregion
                            #region Connection
                            case CONNECT:
                                try
                                {
                                    clientsIp.Add(IPAddress.Parse(parameters[0]));
                                    SendMessage(CONNECTED + ENDTYPE + ENDCOMMAND, client);
                                }
                                catch { }
                                break;
                            #endregion
                            #region Doesn't exist
                            default:
                                SendMessage(ERROR + ENDTYPE + ENDCOMMAND, client);
                                throw new NotImplementedException();
                                break;
                                #endregion
                        }
                    }
                    else
                        SendMessage(ERROR + ENDDATASIGN, data.Item2);
                }
                else
                    Console.Write(DateTime.Now.ToString() + "> " + "NULL");


                if (debugMode)
                    Console.WriteLine("\tProcessed in {0} millisecondes", (DateTime.Now.Millisecond - startTime).ToString());
            }
            catch(Exception e) { MessageBox.Show("Une erreur critique est survenue : \n" + e); }     
        }

        /// <summary>
        /// Envoie des données a un client (un message)
        /// </summary>
        /// <param name="Commmand"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool SendMessage(string command, IPAddress ip)
        {
            TcpClient client = new TcpClient(ip.ToString(), port);
            NetworkStream clientStream = client.GetStream();

            try
            {
                clientStream.Write(GetBytes(command), 0, command.Length);
                return true;
            }
            catch
            {
                RemoveClient(ip);
                return false;
            }
        }

        /// <summary>
        /// Envoie des données a un client (un message)
        /// </summary>
        /// <param name="Commmand"></param>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool SendMessage(string command, TcpClient client)
        {
            NetworkStream clientStream = client.GetStream();

            try
            {
                clientStream.Write(GetBytes(command), 0, command.Length);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Envoie des données aux clients (un message)
        /// </summary>
        /// <param name="command"></param>
        public void BroadCast(string command)
        {
            int maxTent = 5;

            // On fait la liste de tous les clients connectés
            List<IPAddress> tempClients = new List<IPAddress>(clientsIp);

            // On exécute la commande donnée pour chaque client
            while (maxTent != 0)
            {
                foreach (IPAddress ip in tempClients)
                {                  
                    TcpClient client = new TcpClient(ip.ToString(), port);
                    NetworkStream clientStreamTest = client.GetStream();

                    try
                    {
                        clientStreamTest.Write(GetBytes(command), 0, command.Length);

                        int i = clientStreamTest.Read(bytes, 0, bytes.Length);

                        if (Encoding.ASCII.GetString(bytes, 0, i) == Library.CommandList.DATAVERIF + command)
                            maxTent = 0;
                        else if (maxTent > 0)
                            maxTent--;
                        else
                            RemoveClient(ip);
                    }
                    catch
                    {
                            RemoveClient(ip);
                    }
                }
            }
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

        /// <summary>
        /// Vérifie que tous les joueurs soient bien connectés, et les enlève si ils ne le sont pas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestConnectedPlayers(object sender, System.Timers.ElapsedEventArgs e)
        {
            // On fait la liste de tous les clients connectés
            List<IPAddress> tempClients = new List<IPAddress>(clientsIp);
            NetworkStream clientStreamTest;
            int posY = 1;

            // Pour chaque adresse ip connectée, on teste la connection.
            foreach (IPAddress ip in tempClients)
            {
                try
                {
                    TcpClient client = new TcpClient(ip.ToString(), port);
                    clientStreamTest = client.GetStream();
                    clientStreamTest.Write(GetBytes(Library.CommandList.CONNEXIONTEST), 0, Library.CommandList.CONNEXIONTEST.Length);

                    // Si la commande est fausse, alors il y a un problème avec la connexion et on enlève le client.
                    try
                    {
                        int i = clientStreamTest.Read(bytes, 0, bytes.Length);

                        if (Encoding.ASCII.GetString(bytes, 0, i) != Library.CommandList.CONNEXIONTEST)
                            RemoveClient(ip);
                    }
                    catch (System.IO.IOException)
                    {
                        RemoveClient(ip);
                    }

                    clientStreamTest.Close();
                }
                catch (SocketException)
                {
                    RemoveClient(ip);
                }
            }
            posY++;
        }

        /// <summary>
        /// Méthode qui enlève un client de la liste des clients connectés
        /// </summary>
        /// <param name="ip"></param>
        public void RemoveClient(IPAddress ip)
        {
            clientsIp.Remove(ip);
            lostClientsIp.Add(ip);
        }
    }
}
