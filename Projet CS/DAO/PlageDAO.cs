using Projet_CS.DAL;
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
    public class PlageDAO
    {
        public int idPlageDAO;
        public string nomPlageDAO;
        public int idCommuneDAO;
        public int nbEspecesDifferentesDAO;
        public float surfaceDAO;
        public PlageDAO(int idPlageDAO, string nomPlageDAO, int idCommuneDAO, int nbEspecesDifferentesDAO, float surfaceDAO)
        {
            this.idPlageDAO = idPlageDAO;
            this.nomPlageDAO = nomPlageDAO;
            this.idCommuneDAO= idCommuneDAO;
            this.nbEspecesDifferentesDAO = nbEspecesDifferentesDAO;
            this. surfaceDAO = surfaceDAO;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }
        public static ObservableCollection<PlageDAO> listePlages()
        {
            ObservableCollection<PlageDAO> l = PlageDAL.selectPlages();
            return l;
        }

        public static PlageDAO getPlages(int idPlage)
        {
            PlageDAO u = PlageDAL.getPlage(idPlage);
            return u;
        }

        public static void updatePlage(PlageDAO p)
        {
            PlageDAL.updatePlage(p);
        }

        public static void supprimerPlage(int id)
        {
            PlageDAL.supprimerPlage(id);
        }

        public static void insertPlage(PlageDAO p)
        {
            PlageDAL.insertPlage(p);
        }
    }
}
