﻿using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.DAO
{
    public class UtilisateurDAO
    {
        public int idUtilisateurDAO;
        public string nomUtilisateurDAO;
        public string prenomUtilisateurDAO;
        public byte isAdminUtilisateurDAO;
        public string passwordUtilisateurDAO;
        public string loginUtilisateurDAO;
        public UtilisateurDAO(int idUtilisateurDAO, string nomUtilisateurDAO, string prenomUtilisateurDAO, byte isAdminUtilisateurDAO, string passwordUtilisateurDAO, string loginUtilisateurDAO)
        {
            this.idUtilisateurDAO = idUtilisateurDAO;
            this.nomUtilisateurDAO = nomUtilisateurDAO;
            this.prenomUtilisateurDAO = prenomUtilisateurDAO;
            this.isAdminUtilisateurDAO = isAdminUtilisateurDAO;
            this.passwordUtilisateurDAO = passwordUtilisateurDAO;
            this.loginUtilisateurDAO = loginUtilisateurDAO;
        }
        public static ObservableCollection<UtilisateurDAO> listeUtilisateurs()
        {
            ObservableCollection<UtilisateurDAO> l = UtilisateurDAL.selectUtilisateurs();
            return l;
        }

        public static UtilisateurDAO getUtilisateurs(int idUtilisateur)
        {
            UtilisateurDAO u = UtilisateurDAL.getUtilisateur(idUtilisateur);
            return u;
        }
        public static UtilisateurDAO getUtilisateurs(string loginUtilisateur)
        {
            UtilisateurDAO u = UtilisateurDAL.getUtilisateur(loginUtilisateur);
            return u;
        }

        public static void updateUtilisateur(UtilisateurDAO u)
        {
            UtilisateurDAL.updateUtilisateur(u);
        }

        public static void supprimerUtilisateur(int id)
        {
            UtilisateurDAL.supprimerUtilisateur(id);
        }

        public static void insertUtilisateur(UtilisateurDAO u)
        {
            UtilisateurDAL.insertUtilisateur(u);
        }
    }
}
