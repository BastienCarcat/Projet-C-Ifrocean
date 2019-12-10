﻿using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_CS.DAL;
using Projet_CS.DAO;

namespace Projet_CS.DAL
{
    class UtilisateurDAL
    {
        
        public static ObservableCollection<UtilisateurDAO> selectUtilisateurs()
        {
            ObservableCollection<UtilisateurDAO> l = new ObservableCollection<UtilisateurDAO>();
            string query = "SELECT * FROM utilisateur;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UtilisateurDAO u = new UtilisateurDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetByte(3), reader.GetString(4), reader.GetString(5));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static UtilisateurDAO getUtilisateur(int idUtilisateur)
        {
            string query = "SELECT * FROM utilisateur WHERE idUtilisateur=" + idUtilisateur + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            UtilisateurDAO user = new UtilisateurDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetByte(3), reader.GetString(4), reader.GetString(5));
            reader.Close();
            return user;
        }
        public static void updateUtilisateur(UtilisateurDAO u)
        {
            string query = "UPDATE utilisateur set nom=\"" + u.nomUtilisateurDAO + "\", prenom=\"" + u.prenomUtilisateurDAO + "\", isAdmin=\"" + u.isAdminUtilisateurDAO + "\", password=\"" + u.passwordUtilisateurDAO + "\", login=\"" + u.loginUtilisateurDAO + "\" where idUtilisateur=" + u.idUtilisateurDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertUtilisateur(UtilisateurDAO u)
        {
            int id = getMaxIdUtilisateur() + 1;
            string query = "INSERT INTO utilisateur VALUES (\"" + id + "\",\"" + u.nomUtilisateurDAO + "\",\"" + u.prenomUtilisateurDAO + "\",\"" + u.isAdminUtilisateurDAO + "\",\"" + u.passwordUtilisateurDAO + "\",\"" + u.loginUtilisateurDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdUtilisateur()
        {
            string query = "SELECT IFNULL(MAX(idUtilisateur),0) FROM utilisateur;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdUtilisateur = reader.GetInt32(0);
            reader.Close();
            return maxIdUtilisateur;
        }
        public static void supprimerUtilisateur(int id)
        {
            string query = "DELETE FROM Utilisateur WHERE idUtilisateur = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}