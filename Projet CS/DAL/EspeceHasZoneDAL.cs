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
    class EspeceHasZoneDAL
    {

        public static ObservableCollection<EspeceHasZoneDAO> selectEspeceHasZones()
        {
            ObservableCollection<EspeceHasZoneDAO> l = new ObservableCollection<EspeceHasZoneDAO>();
            string query = "SELECT * FROM Espece_has_Zone;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EspeceHasZoneDAO u = new EspeceHasZoneDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
                l.Add(u);
            }
            reader.Close();
            return l;
        }

        public static EspeceHasZoneDAO getEspeceHasZone(int idEspece, int idZone)
        {
            string query = "SELECT * FROM Espece_has_Zone WHERE Espece_idEspece=" + idEspece + " and Zone_idZone=" + idZone + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EspeceHasZoneDAO Espece;
            if (reader.HasRows)
            {
                Espece = new EspeceHasZoneDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2));
            }
            else
            {
                Espece = new EspeceHasZoneDAO(1, 1, 1);
            }
            reader.Close();
            return Espece;
        }


        public static void updateEspeceHasZone(EspeceHasZoneDAO e)
        {
            string query = "UPDATE Espece_has_Zone SET nombreEspeceZone =" + e.nombreEspeceZoneDAO + " WHERE Espece_idEspece =" + e.Espece_idEspeceDAO + " AND Zone_idZone =" + e.Zone_idZoneDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEspeceHasZone(EspeceHasZoneDAO e)
        {
            string query = "INSERT INTO Espece_has_Zone VALUES (\"" + e.Espece_idEspeceDAO + "\",\"" + e.Zone_idZoneDAO + "\",\"" + e.nombreEspeceZoneDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }

        public static void supprimerEspeceHasZone(int idEspece, int idZone)
        {
            string query = "DELETE FROM Espece_has_Zone WHERE Espece_idEspece =" + idEspece + " AND Zone_idZone =" + idZone + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }

    }
}
