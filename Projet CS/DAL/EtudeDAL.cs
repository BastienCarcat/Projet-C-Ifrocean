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
    class EtudeDAL
    {
       
        public static ObservableCollection<EtudeDAO> selectEtudes()
        {
            ObservableCollection<EtudeDAO> l = new ObservableCollection<EtudeDAO>();
            string query = "SELECT * FROM Etude;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EtudeDAO u = new EtudeDAO(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static EtudeDAO getEtude(int idEtude)
        {
            string query = "SELECT * FROM Etude WHERE idEtude=" + idEtude + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EtudeDAO user = new EtudeDAO(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
            reader.Close();
            return user;
        }
        public static void updateEtude(EtudeDAO u)
        {
            string query = "UPDATE Etude set date=\"" + u.dateEtudeDAO + "\", titre=\"" + u.titreEtudeDAO + "\", nbTotalEspeceRencontree=\"" + u.nbTotalEspeceRencontreeEtudeDAO + "\", idEquipe=\"" + u.idEquipeEtudeDAO + "\" where idEtude=" + u.idEtudeDAO + ";";
            //UPDATE Etude set date= + STR_TO_DATE('\"" + u.dateEtudeDAO + "\"', ' % d/%m/%Y %H:%i:%s'), titre=\"" + u.titreEtudeDAO + "\", nbTotalEspeceRencontree=\"" + u.nbTotalEspeceRencontreeEtudeDAO + "\", idEquipe=\"" + u.idEquipeEtudeDAO + "\" where idEtude=" + u.idEtudeDAO + ";"
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEtude(EtudeDAO u)
        {
            int id = getMaxIdEtude() + 1;
            string query = "INSERT INTO Etude VALUES (\"" + id + "\",\"" + u.dateEtudeDAO + "\",\"" + u.titreEtudeDAO + "\",\"" + u.nbTotalEspeceRencontreeEtudeDAO + "\",\"" + u.idEquipeEtudeDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdEtude()
        {
            string query = "SELECT IFNULL(MAX(idEtude),0) FROM Etude;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdEtude = reader.GetInt32(0);
            reader.Close();
            return maxIdEtude;
        }
        public static void supprimerEtude(int id)
        {
            string query = "DELETE FROM Etude WHERE idEtude = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
