using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_CS.DAL;
using Projet_CS.DAO;
using System.Security.Cryptography;

namespace Projet_CS.DAL
{
    class EspeceHasPlageDAL
    {

        public static ObservableCollection<EspeceHasPlageDAO> selectEspeceHasPlages()
        {
            ObservableCollection<EspeceHasPlageDAO> l = new ObservableCollection<EspeceHasPlageDAO>();
            string query = "SELECT * FROM Espece_has_Plage;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EspeceHasPlageDAO u = new EspeceHasPlageDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDecimal(2), reader.GetDecimal(3));
                l.Add(u);
            }
            reader.Close();
            return l;
        }

        public static EspeceHasPlageDAO getEspeceHasPlage(int idEspece, int idPlage)
        {
            string query = "SELECT * FROM Espece_has_Plage WHERE Espece_idEspece=" + idEspece + " and plage_idPlage=" + idPlage + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EspeceHasPlageDAO Espece;
            if (reader.HasRows)
            {
                Espece = new EspeceHasPlageDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDecimal(2), reader.GetDecimal(3));
            }
            else
            {
                Espece = new EspeceHasPlageDAO(1, 1, 0.0M, 0.0M);
            }
            reader.Close();
            return Espece;
        }


        public static void updateEspeceHasPlage(EspeceHasPlageDAO e)
        {
            string query = "UPDATE Espece_has_Plage SET densite =" + e.densiteDAO + ", populationTotale =" + e.populationTotaleDAO + " WHERE Espece_idEspece =" + e.Espece_idEspeceDAO + " AND Plage_idPlage =" + e.Plage_idPlageDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEspeceHasPlage(EspeceHasPlageDAO e)
        {
            string query = "INSERT INTO Espece_has_Plage VALUES (\"" + e.Espece_idEspeceDAO + "\",\"" + e.Plage_idPlageDAO + "\",\"" + e.densiteDAO + "\",\"" + e.populationTotaleDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }

        public static void supprimerEspeceHasPlage(int idEspece, int idPlage)
        {
            string query = "DELETE FROM Espece_has_Plage WHERE Espece_idEspece =" + idEspece + " AND Plage_idPlage =" + idPlage + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }

    }
}
