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
    class EquipeDAL
    {
        private static MySqlConnection connection;
        public EquipeDAL()
        {
            DALConnection.OpenConnection(); //  si la connexion est déjà ouverte, il ne la refera pas (voir code dans DALConnection)
            connection = DALConnection.connection;
        }
        public static ObservableCollection<EquipeDAO> selectEquipes()
        {
            ObservableCollection<EquipeDAO> l = new ObservableCollection<EquipeDAO>();
            string query = "SELECT * FROM Equipe;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EquipeDAO e = new EquipeDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                l.Add(e);
            }
            reader.Close();
            return l;
        }
        public static EquipeDAO getEquipe(int idEquipe)
        {
            string query = "SELECT * FROM Equipe WHERE idEquipe=" + idEquipe + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EquipeDAO user = new EquipeDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            reader.Close();
            return user;
        }
        public static void updateEquipe(EquipeDAO e)
        {
            string query = "UPDATE Equipe set nom=\"" + e.nomEquipeDAO + "\", nombreMembres=\"" + e.nombreMembresEquipeDAO + "\" where idEquipe=" + e.idEquipeDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEquipe(EquipeDAO e)
        {
            int id = getMaxIdEquipe() + 1;
            string query = "INSERT INTO Equipe VALUES (\"" + id + "\",\"" + e.nomEquipeDAO + "\",\"" + e.nombreMembresEquipeDAO+ "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdEquipe()
        {
            string query = "SELECT MAX(idEquipe) FROM Equipe;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdEquipe = reader.GetInt32(0);
            reader.Close();
            return maxIdEquipe;
        }
        public static void supprimerEquipe(int id)
        {
            string query = "DELETE FROM Equipe WHERE idEquipe = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
