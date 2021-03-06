﻿using MySql.Data.MySqlClient;
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
    class DepartementDAL
    {
        
        public static ObservableCollection<DepartementDAO> selectDepartements()
        {
            ObservableCollection<DepartementDAO> l = new ObservableCollection<DepartementDAO>();
            string query = "SELECT * FROM departement;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DepartementDAO u = new DepartementDAO(reader.GetInt32(0), reader.GetString(1));
                l.Add(u);
            }
            reader.Close();
            return l;
        }
        public static DepartementDAO getDepartement(int idDepartement)
        {
            string query = "SELECT * FROM departement WHERE idDepartement=" + idDepartement + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            DepartementDAO departement;
            if (reader.HasRows)
            {
                departement = new DepartementDAO(reader.GetInt32(0), reader.GetString(1));
            }
            else
            {
                departement = new DepartementDAO(1, "MauvaisNumeroDepartement");
            }
            reader.Close();
            return departement;
        }
        //public static DepartementDAO getDepartementName()
        //{
        //  string query = "SELECT * FROM departement;";
        //MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
        //cmd.ExecuteNonQuery();
        //MySqlDataReader reader = cmd.ExecuteReader();
        //  while (reader.Read())
        //{

        //}
        //      return departement;
        //}
        public static void updateDepartement(DepartementDAO u)
        {
            string query = "UPDATE departement set nom=\"" + u.nomDepartementDAO + "\" where idDepartement=" + u.idDepartementDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertDepartement(DepartementDAO u)
        {
            int id = getMaxIdDepartement() + 1;
            string query = "INSERT INTO departement VALUES (\"" + id + "\",\"" + u.nomDepartementDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdDepartement()
        {
            string query = "SELECT IFNULL(MAX(idDepartement),0) FROM departement;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            cmd.ExecuteNonQuery();

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int maxIdDepartement = reader.GetInt32(0);
            reader.Close();
            return maxIdDepartement;
        }
        public static void supprimerDepartement(int id)
        {
            string query = "DELETE FROM departement WHERE idDepartement = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.connection);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
