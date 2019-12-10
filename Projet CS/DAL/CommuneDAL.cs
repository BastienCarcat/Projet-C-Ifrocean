using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_CS.DAL;
using Projet_CS.DAO;
using System.Globalization;
using System.Threading;

namespace Projet_CS.DAL
{
    class CommuneDAL
    {
        private static MySqlConnection connection;
        public CommuneDAL()
        {
            DALConnection.OpenConnection(); //  si la connexion est déjà ouverte, il ne la refera pas (voir code dans DALConnection)
            connection = DALConnection.connection;
        }
        public static ObservableCollection<CommuneDAO> selectCommunes()
        {
            ObservableCollection<CommuneDAO> l = new ObservableCollection<CommuneDAO>();
            string query = "SELECT * FROM Commune;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CommuneDAO u = new CommuneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static CommuneDAO getCommune(int idCommune)
        {
            string query = "SELECT * FROM Commune WHERE idCommune=" + idCommune + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            CommuneDAO user = new CommuneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            reader.Close();
            if (reader.HasRows)
            {
                user = new CommuneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }
            else
            {
                int maxId = getMaxIdCommune() + 1;
                user = new CommuneDAO(maxId, "", 1);
            }
            return user;
        }
        public static void updateCommune(CommuneDAO u)
        {
            string query = "UPDATE Commune set nom=\"" + u.nomCommuneDAO + "\", idDepartement=\"" + u.idDepartementDAO + "\" where idCommune=" + u.idCommuneDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertCommune(CommuneDAO u)
        {
            int id = getMaxIdCommune() + 1;
            string query = "INSERT INTO Commune VALUES (\"" + id + "\",\"" + u.nomCommuneDAO + "\",\"" + u.idDepartementDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdCommune()
        {
            string query = "SELECT MAX(idCommune) FROM Commune;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdCommune = reader.GetInt32(0);
            reader.Close();
            return maxIdCommune;
        }
        public static void supprimerCommune(int id)
        {
            string query = "DELETE FROM Commune WHERE idCommune = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
