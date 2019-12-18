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
    class ZoneORM
    {
        public static ZoneViewModel getZone(int idZone)
        {
            ZoneDAO pDAO = ZoneDAO.getZones(idZone);            
            ZoneViewModel e = new ZoneViewModel(pDAO.idZonePrelevementDAO, pDAO.nomZonePrelevementDAO, pDAO.lat1DAO, pDAO.lat2DAO, pDAO.lat3DAO, pDAO.lat4DAO, pDAO.long1DAO, pDAO.long2DAO, pDAO.long3DAO, pDAO.long4DAO);
            return e;
        }

        public static ObservableCollection<ZoneViewModel> listeZones()
        {
            ObservableCollection<ZoneDAO> lDAO = ZoneDAO.listeZones();
            ObservableCollection<ZoneViewModel> l = new ObservableCollection<ZoneViewModel>();
            foreach (ZoneDAO element in lDAO)
            {                
                ZoneViewModel e = new ZoneViewModel(element.idZonePrelevementDAO, element.nomZonePrelevementDAO, element.lat1DAO, element.lat2DAO, element.lat3DAO, element.lat4DAO, element.long1DAO, element.long2DAO, element.long3DAO, element.long4DAO);
                l.Add(e);
            }
            return l;
        }
        public static void updateZone(ZoneViewModel zp)
        {
            ZoneDAO.updateZone(new ZoneDAO(zp.idZonePrelevementProperty, zp.nomZonePrelevementProperty, zp.lat1Property, zp.lat2Property, zp.lat3Property, zp.lat4Property, zp.long1Property, zp.long2Property, zp.long3Property, zp.long4Property));
        }

        public static void supprimerZone(int id)
        {
            ZoneDAO.supprimerZone(id);
        }

        public static void insertZone(ZoneViewModel zp)
        {
            ZoneDAO.insertZone(new ZoneDAO(zp.idZonePrelevementProperty, zp.nomZonePrelevementProperty, zp.lat1Property, zp.lat2Property, zp.lat3Property, zp.lat4Property, zp.long1Property, zp.long2Property, zp.long3Property, zp.long4Property));
        }
    }
}
