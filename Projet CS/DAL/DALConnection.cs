using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_CS.DAL
{
    class DALConnection
    {
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        public static MySqlConnection connection;

        public static Boolean OpenConnection()
        {
            if (connection == null) //  si la connexion est déjà ouverte, il ne la refera pas 
            {

                server = "localhost";
                database = "projetb2csharp";
                uid = "projet";
                password = "UnsK74UJHMXWDFPa9UZvk";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
                connection.Open();             
            }
            return true;
        }
    }
}
