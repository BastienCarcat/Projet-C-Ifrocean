using Projet_CS.DAL;
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
    public class ZoneDAO
    {
        public int idZonePrelevementDAO;
        public string nomZonePrelevementDAO;
        public Decimal lat1DAO;
        public Decimal lat2DAO;
        public Decimal lat3DAO;
        public Decimal lat4DAO;
        public Decimal long1DAO;
        public Decimal long2DAO;
        public Decimal long3DAO;
        public Decimal long4DAO;
        public ZoneDAO(int idZonePrelevementDAO, string nomZonePrelevementDAO, Decimal lat1DAO, Decimal lat2DAO, Decimal lat3DAO, Decimal lat4DAO, Decimal long1DAO, Decimal long2DAO, Decimal long3DAO, Decimal long4DAO)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.idZonePrelevementDAO = idZonePrelevementDAO;
            this.nomZonePrelevementDAO = nomZonePrelevementDAO;
            this.lat1DAO = lat1DAO;
            this.lat2DAO = lat2DAO;
            this.lat3DAO = lat3DAO;
            this.lat4DAO = lat4DAO;
            this.long1DAO = long1DAO;
            this.long2DAO = long2DAO;
            this.long3DAO = long3DAO;
            this.long4DAO = long4DAO;

        }
        public static ObservableCollection<ZoneDAO> listeZones()
        {
            ObservableCollection<ZoneDAO> l = ZoneDAL.selectZones();
            return l;
        }

        public static ZoneDAO getZones(int idZone)
        {
            ZoneDAO e = ZoneDAL.getZone(idZone);
            return e;
        }

        public static void updateZone(ZoneDAO zp)
        {
            ZoneDAL.updateZone(zp);
        }

        public static void supprimerZone(int id)
        {
            ZoneDAL.supprimerZone(id);
        }

        public static void insertZone(ZoneDAO zp)
        {
            ZoneDAL.insertZone(zp);
        }
    }
}
