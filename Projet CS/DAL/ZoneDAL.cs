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
    class ZoneDAL
    {

        public static ObservableCollection<ZoneDAO> selectZones()
        {
            ObservableCollection<ZoneDAO> l = new ObservableCollection<ZoneDAO>();
            string query = "SELECT * FROM zoneprelevement;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ZoneDAO u = new ZoneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8), reader.GetDecimal(9));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static ZoneDAO getZone(int idZone)
        {
            string query = "SELECT * FROM zoneprelevement WHERE idZonePrelevement=" + idZone + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ZoneDAO zone;
            if (reader.HasRows)
            {
                zone = new ZoneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetDecimal(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8), reader.GetDecimal(9));
            }
            else
            {
                zone = new ZoneDAO(1, "Mauvais Num Zone", 0.0M, 0.0M, 0.0M, 0.0M, 0.0M, 0.0M, 0.0M, 0.0M);
            }
            reader.Close();
            return zone;
        }
        public static void updateZone(ZoneDAO u)
        {
            string query = "UPDATE zoneprelevement set nom=\"" + u.nomZonePrelevementDAO + "\", lat1=\"" + u.lat1DAO + "\", lat2=\"" + u.lat2DAO + "\", lat3=\"" + u.lat3DAO + "\", lat4=\"" + u.lat4DAO + "\", long1=\"" + u.long1DAO + "\", long2=\"" + u.long2DAO + "\", long3=\"" + u.long3DAO + "\", long4=\"" + u.long4DAO + "\" where idZonePrelevement=" + u.idZonePrelevementDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertZone(ZoneDAO u)
        {
            int id = getMaxIdZone() + 1;
            string query = "INSERT INTO zoneprelevement VALUES (\"" + id + "\",\"" + u.nomZonePrelevementDAO + "\",\"" + u.lat1DAO + "\",\"" + u.lat2DAO + "\",\"" + u.lat3DAO + "\",\"" + u.lat4DAO + "\",\"" + u.long1DAO + "\",\"" + u.long2DAO + "\",\"" + u.long3DAO + "\",\"" + u.long4DAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdZone()
        {
            string query = "SELECT IFNULL(MAX(idZonePrelevement),0) FROM zoneprelevement;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdZone = reader.GetInt32(0);
            reader.Close();
            return maxIdZone;
        }
        public static void supprimerZone(int id)
        {
            string query = "DELETE FROM zoneprelevement WHERE idZonePrelevement = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
