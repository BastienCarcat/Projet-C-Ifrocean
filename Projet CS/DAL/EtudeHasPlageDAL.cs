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
    class EtudeHasPlageDAL
    {

        public static ObservableCollection<EtudeHasPlageDAO> selectEtudeHasPlages()
        {
            ObservableCollection<EtudeHasPlageDAO> l = new ObservableCollection<EtudeHasPlageDAO>();
            string query = "SELECT * FROM etude_has_Plage;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EtudeHasPlageDAO u = new EtudeHasPlageDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        
        public static EtudeHasPlageDAO getEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            string query = "SELECT * FROM etude_has_Plage WHERE Etude_idEtude=" + idEtude + " and plage_idPlage=" + idPlage + " and zoneprelevement_idZonePrelevement=" + idZone + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EtudeHasPlageDAO etude;
            if (reader.HasRows)
            {
                etude = new EtudeHasPlageDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3));
            }
            else
            {
                etude = new EtudeHasPlageDAO(1, 1, 1, "Pas de nom");
            }
            reader.Close();
            return etude;
        }


        public static void updateEtudeHasPlage(EtudeHasPlageDAO e)
        {
            string query = "UPDATE etude_has_Plage SET name_concatenation =" + e.name_concatenationDAO + " WHERE Etude_idEtude =" + e.Etude_idEtudeDAO + " AND Plage_idPlage =" + e.Plage_idPlageDAO + " AND zoneprelevement_idZonePrelevement =" + e.Zone_idZoneDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEtudeHasPlage(EtudeHasPlageDAO e)
        {
            string query = "INSERT INTO etude_has_Plage VALUES (\"" + e.Etude_idEtudeDAO + "\",\"" + e.Plage_idPlageDAO + "\",\"" + e.Zone_idZoneDAO + "\",\"" + e.name_concatenationDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
       
        public static void supprimerEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            string query = "DELETE FROM etude_has_Plage WHERE Etude_idEtude =" + idEtude + " AND Plage_idPlage =" + idPlage + " AND zoneprelevement_idZonePrelevement =" + idZone + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }

    }
}
