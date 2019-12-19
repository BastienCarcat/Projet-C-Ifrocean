using Projet_CS.DAO;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.ORM
{
    class EspeceHasZoneORM
    {

        public static EspeceHasZoneViewModel getEspeceHasZone(int idEspece, int idZone)
        {
            EspeceHasZoneDAO eDAO = EspeceHasZoneDAO.getEspeceHasZone(idEspece, idZone);

            int Espece_idEspece = eDAO.Espece_idEspeceDAO;
            EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

            int Zone_idZone = eDAO.Zone_idZoneDAO;
            ZoneViewModel z = ZoneORM.getZone(Zone_idZone);

            EspeceHasZoneViewModel ez = new EspeceHasZoneViewModel(e, z, eDAO.nombreEspeceZoneDAO);
            return ez;
        }

        public static ObservableCollection<EspeceHasZoneViewModel> listeEspeceHasZones()
        {
            ObservableCollection<EspeceHasZoneDAO> lDAO = EspeceHasZoneDAO.listeEspeceHasZones();
            ObservableCollection<EspeceHasZoneViewModel> l = new ObservableCollection<EspeceHasZoneViewModel>();
            foreach (EspeceHasZoneDAO element in lDAO)
            {

                int Espece_idEspece = element.Espece_idEspeceDAO;
                EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

                int Zone_idZone = element.Zone_idZoneDAO;
                ZoneViewModel z = ZoneORM.getZone(Zone_idZone);

                EspeceHasZoneViewModel ez = new EspeceHasZoneViewModel(e, z, element.nombreEspeceZoneDAO);
                l.Add(ez);
            }
            return l;
        }
        public static void updateEspeceHasZone(EspeceHasZoneViewModel ez)
        {
            EspeceHasZoneDAO.updateEspeceHasZone(new EspeceHasZoneDAO(ez.Espece_EspeceHasZoneProperty.idEspeceProperty, ez.Zone_EspeceHasZoneProperty.idZonePrelevementProperty, ez.nombreEspeceZoneProperty));
        }

        public static void supprimerEspeceHasZone(int idEspece, int idZone)
        {
            EspeceHasZoneDAO.supprimerEspeceHasZone(idEspece, idZone);
        }
        public static void insertEspeceHasZone(EspeceHasZoneViewModel ez)
        {
            EspeceHasZoneDAO.insertEspeceHasZone(new EspeceHasZoneDAO(ez.Espece_EspeceHasZoneProperty.idEspeceProperty, ez.Zone_EspeceHasZoneProperty.idZonePrelevementProperty, ez.nombreEspeceZoneProperty));
        }
    }
}
