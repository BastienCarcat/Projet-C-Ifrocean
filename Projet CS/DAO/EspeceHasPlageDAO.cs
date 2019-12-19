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
    public class EspeceHasPlageDAO
    {
        public int Espece_idEspeceDAO;
        public int Plage_idPlageDAO;
        public Decimal densiteDAO;
        public Decimal populationTotaleDAO;

        public EspeceHasPlageDAO(int idEspece, int idPlage, Decimal densite, Decimal populationTotale)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.Espece_idEspeceDAO = idEspece;
            this.Plage_idPlageDAO = idPlage;
            this.densiteDAO = densite;
            this.populationTotaleDAO = populationTotale;
        }

        public static ObservableCollection<EspeceHasPlageDAO> listeEspeceHasPlages()
        {
            ObservableCollection<EspeceHasPlageDAO> l = EspeceHasPlageDAL.selectEspeceHasPlages();
            return l;
        }

        public static EspeceHasPlageDAO getEspeceHasPlage(int idEspece, int idPlage)
        {
            EspeceHasPlageDAO u = EspeceHasPlageDAL.getEspeceHasPlage(idEspece, idPlage);
            return u;
        }

        public static void updateEspeceHasPlage(EspeceHasPlageDAO u)
        {
            EspeceHasPlageDAL.updateEspeceHasPlage(u);
        }

        public static void supprimerEspeceHasPlage(int idEspece, int idPlage)
        {
            EspeceHasPlageDAL.supprimerEspeceHasPlage(idEspece, idPlage);
        }

        public static void insertEspeceHasPlage(EspeceHasPlageDAO u)
        {
            EspeceHasPlageDAL.insertEspeceHasPlage(u);
        }
    }
}
