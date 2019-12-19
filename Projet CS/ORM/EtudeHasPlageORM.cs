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
    class EtudeHasPlageORM
    {

        public static EtudeHasPlageViewModel getEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            EtudeHasPlageDAO eDAO = EtudeHasPlageDAO.getEtudeHasPlage(idEtude, idPlage, idZone);

            int Etude_idEtude = eDAO.Etude_idEtudeDAO;
            EtudeViewModel et = EtudeORM.getEtude(Etude_idEtude);

            int Plage_idPlage = eDAO.Plage_idPlageDAO;
            PlageViewModel p = PlageORM.getPlage(Plage_idPlage);

            int Zone_idZone = eDAO.Zone_idZoneDAO;
            ZoneViewModel z = ZoneORM.getZone(Zone_idZone);

            EtudeHasPlageViewModel ep = new EtudeHasPlageViewModel(et, p, z, eDAO.name_concatenationDAO);
            return ep;
        }

        public static ObservableCollection<EtudeHasPlageViewModel> listeEtudeHasPlages()
        {
            ObservableCollection<EtudeHasPlageDAO> lDAO = EtudeHasPlageDAO.listeEtudeHasPlages();
            ObservableCollection<EtudeHasPlageViewModel> l = new ObservableCollection<EtudeHasPlageViewModel>();
            foreach (EtudeHasPlageDAO element in lDAO)
            {

                int Etude_idEtude = element.Etude_idEtudeDAO;
                EtudeViewModel et = EtudeORM.getEtude(Etude_idEtude);

                int Plage_idPlage = element.Plage_idPlageDAO;
                PlageViewModel p = PlageORM.getPlage(Plage_idPlage);

                int Zone_idZone = element.Zone_idZoneDAO;
                ZoneViewModel z = ZoneORM.getZone(Zone_idZone);

                EtudeHasPlageViewModel ep = new EtudeHasPlageViewModel(et, p, z, element.name_concatenationDAO);
                l.Add(ep);
            }
            return l;
        }
        public static void updateEtudeHasPlage(EtudeHasPlageViewModel ep)
        {
            EtudeHasPlageDAO.updateEtudeHasPlage(new EtudeHasPlageDAO(ep.Etude_EtudeHasPlageProperty.idEtudeProperty, ep.Plage_EtudeHasPlageProperty.idPlageProperty, ep.Zone_EtudeHasPlageProperty.idZonePrelevementProperty, ep.name_concatenationProperty));
        }

        public static void supprimerEtudeHasPlage(int idEtude, int idPlage, int idZone)
        {
            EtudeHasPlageDAO.supprimerEtudeHasPlage(idEtude, idPlage, idZone);
        }
        public static void insertEtudeHasPlage(EtudeHasPlageViewModel ep)
        {
            EtudeHasPlageDAO.insertEtudeHasPlage(new EtudeHasPlageDAO(ep.Etude_EtudeHasPlageProperty.idEtudeProperty, ep.Plage_EtudeHasPlageProperty.idPlageProperty, ep.Zone_EtudeHasPlageProperty.idZonePrelevementProperty, ep.name_concatenationProperty));
        }
    }
}
