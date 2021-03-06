﻿using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projet_CS.DAO
{
    public class EtudeDAO
    {
        public int idEtudeDAO;
        public DateTime dateEtudeDAO;
        public string titreEtudeDAO;
        public int nbTotalEspeceRencontreeEtudeDAO;
        public int idEquipeEtudeDAO;
        public EtudeDAO(int idEtudeDAO, DateTime dateEtudeDAO, string titreEtudeDAO, int nbTotalEspeceRencontreeEtudeDAO, int idEquipeEtudeDAO)
        {
            this.idEtudeDAO = idEtudeDAO;
            this.dateEtudeDAO = dateEtudeDAO;
            this.titreEtudeDAO = titreEtudeDAO;
            this.nbTotalEspeceRencontreeEtudeDAO = nbTotalEspeceRencontreeEtudeDAO;
            this.idEquipeEtudeDAO = idEquipeEtudeDAO;            
        }
        public static ObservableCollection<EtudeDAO> listeEtudes()
        {
            ObservableCollection<EtudeDAO> l = EtudeDAL.selectEtudes();
            return l;
        }

        public static EtudeDAO getEtudes(int idEtude)
        {
            EtudeDAO u = EtudeDAL.getEtude(idEtude);
            return u;
        }

        public static void updateEtude(EtudeDAO et)
        {
            EtudeDAL.updateEtude(et);
        }

        public static void supprimerEtude(int id)
        {
            EtudeDAL.supprimerEtude(id);
        }

        public static void insertEtude(EtudeDAO et)
        {
            EtudeDAL.insertEtude(et);
        }
    }
}
