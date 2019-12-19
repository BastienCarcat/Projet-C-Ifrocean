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
    class EtudeHasEspeceDAL
    {

        public static ObservableCollection<EtudeHasEspeceDAO> selectEtudeHasEspeces()
        {
            ObservableCollection<EtudeHasEspeceDAO> l = new ObservableCollection<EtudeHasEspeceDAO>();
            string query = "SELECT * FROM etude_has_espece;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EtudeHasEspeceDAO u = new EtudeHasEspeceDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDecimal(2));
                l.Add(u);
            }
            reader.Close();
            return l;
        }

        //Select général -> pas de select de tout les user avec tel equipe

        //public static EtudeHasEspeceDAO getEtudeHasEspeceByUtilisateur(int idUtilisateur)
        //{
        //    string query = "SELECT * FROM etude_has_espece WHERE idUtilisateur=" + idUtilisateur + ";";
        //    MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
        //    cmd.ExecuteNonQuery();
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    EtudeHasEspeceDAO user = new EtudeHasEspeceDAO(reader.GetInt32(0), reader.GetInt32(1),  reader.GetDecimal(2));
        //    reader.Close();
        //    return user;
        //}
        public static EtudeHasEspeceDAO getEtudeHasEspece(int idEtude, int idEspece)
        {
            string query = "SELECT * FROM etude_has_espece WHERE Etude_idEtude=" + idEtude + " and esepce_idEspece=" + idEspece + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EtudeHasEspeceDAO etude;
            if (reader.HasRows)
            {
                etude = new EtudeHasEspeceDAO(reader.GetInt32(0), reader.GetInt32(1), reader.GetDecimal(2));
            }
            else
            {
                etude = new EtudeHasEspeceDAO(1, 1, 0.0M);
            }
            reader.Close();
            return etude;
        }
       

        public static void updateEtudeHasEspece(EtudeHasEspeceDAO e)
        {            
            string query = "UPDATE etude_has_espece SET densiteTotaleEspece =" + e.densiteTotaleEspeceDAO + " WHERE Etude_idEtude =" + e.Etude_idEtudeDAO + " AND Espece_idespece =" + e.Espece_idEspeceDAO + ";";
            
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEtudeHasEspece(EtudeHasEspeceDAO e)
        {
            string query = "INSERT INTO etude_has_espece VALUES (\"" + e.Etude_idEtudeDAO + "\",\"" + e.Espece_idEspeceDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }

        //pas de max id avec plusieurs clés primaires

        //public static int getMaxIdEtudeHasEspece()
        //{
        //    string query = "SELECT IFNULL(MAX(idEtudeHasEspece),0) FROM EtudeHasEspece;";
        //    MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
        //    cmd.ExecuteNonQuery();

        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    int maxIdEtudeHasEspece = reader.GetInt32(0);
        //    reader.Close();
        //    return maxIdEtudeHasEspece;
        //}
        public static void supprimerEtudeHasEspece(int idEtude, int idEspece)
        {
            string query = "DELETE FROM etude_has_espece WHERE Etude_idEtude =" + idEtude + " AND Espece_idEspece =" + idEspece + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }

    }
}
