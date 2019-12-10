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
    class PlageDAL
    {
        
        public static ObservableCollection<PlageDAO> selectPlages()
        {
            ObservableCollection<PlageDAO> l = new ObservableCollection<PlageDAO>();
            string query = "SELECT * FROM Plage;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PlageDAO u = new PlageDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetFloat(4));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static PlageDAO getPlage(int idPlage)
        {
            string query = "SELECT * FROM Plage WHERE idPlage=" + idPlage + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            PlageDAO user = new PlageDAO(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetFloat(4));
            reader.Close();
            return user;
        }
        public static void updatePlage(PlageDAO u)
        {
            string query = "UPDATE Plage set nom=\"" + u.nomPlageDAO + "\", idCommune=\"" + u.idCommuneDAO + "\", nbEspecesDifferentes=\"" + u.nbEspecesDifferentesDAO + "\", surface=\"" + u.surfaceDAO + "\" where idPlage=" + u.idPlageDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertPlage(PlageDAO u)
        {
            int id = getMaxIdPlage() + 1;
            string query = "INSERT INTO Plage VALUES (\"" + id + "\",\"" + u.nomPlageDAO + "\",\"" + u.idCommuneDAO + "\",\"" + u.nbEspecesDifferentesDAO + "\",\"" + u.surfaceDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdPlage()
        {
            string query = "SELECT IFNULL(MAX(idPlage),0) FROM Plage;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdPlage = reader.GetInt32(0);
            reader.Close();
            return maxIdPlage;
        }
        public static void supprimerPlage(int id)
        {
            string query = "DELETE FROM Plage WHERE idPlage = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
