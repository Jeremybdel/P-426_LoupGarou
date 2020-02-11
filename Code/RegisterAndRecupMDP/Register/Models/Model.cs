using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace Werewolf
{
    public class Model
    {
        public Model()
        {
            if (!TryMysqlConn())
            {
                System.Windows.Forms.MessageBox.Show("Connexion au serveur impossible\nMerci de tester votre connexion internet", "Problème de connexion");
                Environment.Exit(0);
            }
        }

        private MySqlConnection cnn;
        private string USERNAME = "root";
        private string PASSWORD = "root";
        public int Id { get; private set; } = 0;
        public string REGEX_NICKNAME = @"^.{3,}$";
        private const string REGEX_EMAIL = @"^[a-zA-Z]{2,}@[a-zA-Z]{1,}$";
        private const string REGEX_PASSWORD = @"^.{3,}$";
        
        public string RegexEmail
        {
            get { return REGEX_EMAIL; }
        }
        public string RegexPassword
        {
            get { return REGEX_PASSWORD; }
        }

        public bool TryConnectUserPseudo(string pseudo, string password)
        {
            string mail = null;
            string pass = null;
            int id1 = int.MaxValue;
            int id2 = 0;
            List<string> end = new List<string>();
            bool ok = false;
            string cmd = null;

                try
                {
                    cmd = $"SELECT accNickname FROM t_account WHERE accNickname = '{pseudo}'";
                    mail = (string)SimpleDataQuerry<string>(cmd);
                    cmd = $"SELECT accPassword FROM t_account WHERE accPassword = '{DisplayHashCode(password)}'";
                    pass = (string)SimpleDataQuerry<string>(cmd);
                    cmd = $"SELECT idAccount FROM t_account WHERE accNickname = '{pseudo}'";
                    id1 = (int)SimpleDataQuerry<int>(cmd);
                    cmd = $"SELECT idAccount FROM t_account WHERE accPassword = '{DisplayHashCode(password)}'";
                    id2 = (int)SimpleDataQuerry<int>(cmd);
                    cmd = $"SELECT idAccount FROM t_account WHERE accEmail = '{pseudo}'";
                    Id = (int)SimpleDataQuerry<int>(cmd);
                try
                    {
                        if (id1 == id2)
                        {
                            ok = true;
                        }
                    }
                    catch
                    {

                    }
                }
                catch (Exception er) { }

            try
            {
                end.Add(mail);
            }
            catch
            {
            }
            try
            {
                end.Add(pass);
            }
            catch
            {
            }

            try
            {
                if (end.Count == 2 && ok)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool TryConnectUserMail(string email, string password)
        {
            string mail = null;
            string pass = null;
            int id1 = int.MaxValue;
            int id2 = 0;
            List<string> end = new List<string>();
            bool ok = false;
            string cmd = null;

                try
                {
                cmd = $"SELECT accEmail FROM t_account WHERE accEmail = '{email}'";
                mail = (string)SimpleDataQuerry<string>(cmd);
                cmd = $"SELECT accPassword FROM t_account WHERE accPassword = '{DisplayHashCode(password)}'";
                pass = (string)SimpleDataQuerry<string>(cmd);
                cmd = $"SELECT idAccount FROM t_account WHERE accEmail = '{email}'";
                id1 = (int)SimpleDataQuerry<int>(cmd);
                cmd = $"SELECT idAccount FROM t_account WHERE accPassword = '{DisplayHashCode(password)}'";
                id2 = (int)SimpleDataQuerry<int>(cmd);
                cmd = $"SELECT idAccount FROM t_account WHERE accEmail = '{email}'";
                Id = (int)SimpleDataQuerry<int>(cmd);
                try
                    {
                        if (id1 == id2)
                        {
                            ok = true;
                        }
                    }
                    catch
                    {

                    }
                }
                catch (Exception er) { }

            try
            {
                end.Add(mail);
            }
            catch
            {
            }
            try
            {
                end.Add(pass);
            }
            catch
            {
            }

            try
            {
                if (end.Count == 2 && ok)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool TryUpdateMDP(string _password)
        {
            string password = _password;
            int id1 = int.MaxValue;
            int id2 = 0;
            List<string> end = new List<string>();
            bool ok = false;
            string cmd = null;

            try
            {
                cmd = $"UPDATE `t_account` SET `accPassword` = '{DisplayHashCode(password)}' WHERE `t_account`.`idAccount` = '{Id}'";
                SimpleDataQuerry<string>(cmd);

                try
                {
                    if (id1 == id2)
                    {
                        ok = true;
                    }
                }
                catch
                {

                }
            }
            catch (Exception er) { }

            try
            {
                end.Add(password);
            }
            catch
            {
            }
            try
            {
                if (end.Count == 1 && ok)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public object DisplayHashCode(string password)
        {
            return password.GetHashCode();
        }

        public void InsertUser(string nickname, string email, string password, byte[] img)
        {
            string cmd = $"INSERT INTO t_account (accNickname, accEmail , accPassword, accAvatar) VALUES ('{nickname}','{email}','{password}','{img}');";
            SimpleDataQuerry<bool>(cmd);
        }
        
        public bool TryMysqlConn()
        {
            string connetionString;
            connetionString = "server=localhost;database=db_werewolf;uid=" + USERNAME + ";pwd=" + PASSWORD + ";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        /// <summary>
        /// Renvoie les valeurs d'une commande sql sous forme d'objet.
        /// Ne peut lire que des structures unidimensionels ou des valeurs uniques.
        /// </summary>
        /// <param name="command">Commande</param>
        /// <param name="value">Type de la structure unidimensionelle</param>
        /// <returns>Structure unidimensionelle</returns>
        public object SimpleDataQuerry<T>(string command)
        {
            TryMysqlConn();

            object value = null;

            List<object> listObjects = new List<object>();

            bool isAList = typeof(T).IsGenericType;

            using (var reader = new MySqlCommand(command, cnn).ExecuteReader())
            {
                while (reader.Read())
                {
                    if (isAList)
                    {
                        Type test = typeof(T);
                        listObjects.Add(Convert.ChangeType(reader.GetValue(0), typeof(object)));
                    }
                    else
                    {
                        value = (Convert.ChangeType(reader.GetValue(0), typeof(object)));
                    }
                }
            }

            if (isAList)
                value = listObjects;

            cnn.Close();

            return value;
        }


        /// <summary>
        /// Renvoie les valeurs d'une commande sql sous forme d'objet.
        /// Ne peut lire que des structures unidimensionelles.
        /// </summary>
        /// <param name="command">Commande</param>
        /// <param name="values">Type de la structure bidimensionelle</param>
        /// <returns>Structure bidimensionelle</returns>
        public void TableDataQuerry(string command, List<object[]> values, int lenght)
        {
            TryMysqlConn();
            using (var reader = new MySqlCommand(command, cnn).ExecuteReader())
            {
                int counter = 0;

                while (reader.Read())
                {
                    object[] o = new object[reader.FieldCount];
                    reader.GetValues(o);
                    values.Add(o);
                    counter++;
                }
            }

            cnn.Close();
        }
    }
}
