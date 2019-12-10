using MySql.Data.MySqlClient;
using Projet_CS.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.DAL
{
    class EspeceDAL
    {
        private static MySqlConnection connection;
        public EspeceDAL()
        {
            DALConnection.OpenConnection(); //  si la connexion est déjà ouverte, il ne la refera pas (voir code dans DALConnection)
            connection = DALConnection.connection;
        }
        public static ObservableCollection<EspeceDAO> selectEspeces()
        {
            ObservableCollection<EspeceDAO> l = new ObservableCollection<EspeceDAO>();
            string query = "SELECT * FROM Espece;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EspeceDAO e = new EspeceDAO(reader.GetInt32(0), reader.GetString(1));
                l.Add(e);
            }
            reader.Close();
            return l;
        }
        public static EspeceDAO getEspece(int idEspece)
        {
            string query = "SELECT * FROM Espece WHERE idEspece=" + idEspece + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EspeceDAO user = new EspeceDAO(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            return user;
        }
        public static void updateEspece(EspeceDAO e)
        {
            string query = "UPDATE Espece set nom=\"" + e.nomEspeceDAO + "\" where idEspece=" + e.idEspeceDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEspece(EspeceDAO e)
        {
            int id = getMaxIdEspece() + 1;
            string query = "INSERT INTO Espece VALUES (\"" + id + "\",\"" + e.nomEspeceDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdEspece()
        {
            string query = "SELECT MAX(idEspece) FROM Espece;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdEspece = reader.GetInt32(0);
            reader.Close();
            return maxIdEspece;
        }
        public static void supprimerEspece(int id)
        {
            string query = "DELETE FROM Espece WHERE idEspece = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
