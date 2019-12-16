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
    }
}
