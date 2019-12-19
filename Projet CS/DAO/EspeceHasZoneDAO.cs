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
    public class EspeceHasZoneDAO
    {
        public int Espece_idEspeceDAO;
        public int Zone_idZoneDAO;
        public int nombreEspeceZoneDAO;        

        public EspeceHasZoneDAO(int idEspece, int idZone, int nombreEspeceZoneDAO)
        {            
            this.Espece_idEspeceDAO = idEspece;
            this.Zone_idZoneDAO = idZone;
            this.nombreEspeceZoneDAO = nombreEspeceZoneDAO;            
        }

        public static ObservableCollection<EspeceHasZoneDAO> listeEspeceHasZones()
        {
            ObservableCollection<EspeceHasZoneDAO> l = EspeceHasZoneDAL.selectEspeceHasZones();
            return l;
        }

        public static EspeceHasZoneDAO getEspeceHasZone(int idEspece, int idZone)
        {
            EspeceHasZoneDAO u = EspeceHasZoneDAL.getEspeceHasZone(idEspece, idZone);
            return u;
        }

        public static void updateEspeceHasZone(EspeceHasZoneDAO u)
        {
            EspeceHasZoneDAL.updateEspeceHasZone(u);
        }

        public static void supprimerEspeceHasZone(int idEspece, int idZone)
        {
            EspeceHasZoneDAL.supprimerEspeceHasZone(idEspece, idZone);
        }

        public static void insertEspeceHasZone(EspeceHasZoneDAO u)
        {
            EspeceHasZoneDAL.insertEspeceHasZone(u);
        }
    }
}
