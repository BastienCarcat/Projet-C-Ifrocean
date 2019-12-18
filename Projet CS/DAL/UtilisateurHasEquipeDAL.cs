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
    class UtilisateurHasEquipeDAL
    {

        public static ObservableCollection<UtilisateurHasEquipeDAO> selectUtilisateurHasEquipes()
        {
            ObservableCollection<UtilisateurHasEquipeDAO> l = new ObservableCollection<UtilisateurHasEquipeDAO>();
            string query = "SELECT * FROM utilisateur_has_equipe;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UtilisateurHasEquipeDAO u = new UtilisateurHasEquipeDAO(reader.GetInt32(0), reader.GetInt32(1));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static UtilisateurHasEquipeDAO getUtilisateurHasEquipeByUtilisateur(int idUtilisateur)
        {
            string query = "SELECT * FROM utilisateur_has_equipe WHERE idUtilisateur=" + idUtilisateur + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            UtilisateurHasEquipeDAO user = new UtilisateurHasEquipeDAO(reader.GetInt32(0), reader.GetInt32(1));
            reader.Close();
            return user;
        }
        public static UtilisateurHasEquipeDAO getUtilisateurHasEquipeByEquipe(int idEquipe)
        {
            string query = "SELECT * FROM UtilisateurHasEquipe WHERE login=" + idEquipe + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            UtilisateurHasEquipeDAO user = new UtilisateurHasEquipeDAO(reader.GetInt32(0), reader.GetInt32(1));
            //if (reader.HasRows)
            //{
            //    user = new UtilisateurHasEquipeDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetByte(3), reader.GetString(4), reader.GetString(5));
            //}
            //else
            //{
            //    user = new UtilisateurHasEquipeDAO(1, "Bad", "UserName", 0, "none", "none");
            //}
            reader.Close();
            return user;
        }
        public static void updateUtilisateurHasEquipe(UtilisateurHasEquipeDAO u)
        {            
            string query = "UPDATE utilisateur_has_equipe SET Utilisateur_idUtilisateur =" + u.Utilisateur_idUtilisateurDAO + ", Equipe_idEquipe=" + u.Equipe_idEquipeDAO + "WHERE Utilisateur_idUtilisateur =" + u.Utilisateur_idUtilisateurDAO + "AND Equipe_idEquipe =" + u.Equipe_idEquipeDAO + ";";
            ///////////???
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertUtilisateurHasEquipe(UtilisateurHasEquipeDAO u)
        {            
            //int id = getMaxIdUtilisateurHasEquipe() + 1;
            string query = "INSERT INTO utilisateur_has_equipe VALUES (\"" + u.Utilisateur_idUtilisateurDAO + "\",\"" + u.Equipe_idEquipeDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        //public static int getMaxIdUtilisateurHasEquipe()
        //{
        //    string query = "SELECT IFNULL(MAX(idUtilisateurHasEquipe),0) FROM UtilisateurHasEquipe;";
        //    MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
        //    cmd.ExecuteNonQuery();

        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    int maxIdUtilisateurHasEquipe = reader.GetInt32(0);
        //    reader.Close();
        //    return maxIdUtilisateurHasEquipe;
        //}
        public static void supprimerUtilisateurHasEquipe(int idUtilisateur, int idEquipe)
        {
            string query = "DELETE FROM utilisateur_has_equipe WHERE utilisateur_idUtilisateur = \"" + idUtilisateur + "\"AND Equipe_idEquipe = \"" + idEquipe + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        
    }
}
