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
    public class EtudeHasPlageDAO
    {
        public int Etude_idEtudeDAO;
        public int Plage_idPlageDAO;
        public int Zone_idZoneDAO;
        public string name_concatenationDAO;        

        public EtudeHasPlageDAO(int idEtude, int idPlage, int idZone, string name_concatenationDAO)
        {            
            this.Etude_idEtudeDAO = idEtude;
            this.Plage_idPlageDAO = idPlage;
            this.Zone_idZoneDAO = idZone;
            this.name_concatenationDAO = name_concatenationDAO;
        }

        public static ObservableCollection<EtudeHasPlageDAO> listeEtudeHasPlages()
        {
            ObservableCollection<EtudeHasPlageDAO> l = EtudeHasPlageDAL.selectEtudeHasPlages();
            return l;
        }

        public static EtudeHasPlageDAO getEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            EtudeHasPlageDAO u = EtudeHasPlageDAL.getEtudeHasPlage(idEtude, idPlage, idZone);
            return u;
        }

        public static void updateEtudeHasPlage(EtudeHasPlageDAO u)
        {
            EtudeHasPlageDAL.updateEtudeHasPlage(u);
        }

        public static void supprimerEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            EtudeHasPlageDAL.supprimerEtudeHasPlage(idEtude, idPlage, idZone);
        }

        public static void insertEtudeHasPlage(EtudeHasPlageDAO u)
        {
            EtudeHasPlageDAL.insertEtudeHasPlage(u);
        }
    }
}
