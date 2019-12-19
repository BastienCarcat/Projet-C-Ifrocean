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
    class EspeceHasPlageORM
    {

        public static EspeceHasPlageViewModel getEspeceHasPlage(int idEspece, int idPlage)
        {
            EspeceHasPlageDAO eDAO = EspeceHasPlageDAO.getEspeceHasPlage(idEspece, idPlage);

            int Espece_idEspece = eDAO.Espece_idEspeceDAO;
            EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

            int Plage_idPlage = eDAO.Plage_idPlageDAO;
            PlageViewModel p = PlageORM.getPlage(Plage_idPlage);

            EspeceHasPlageViewModel ep = new EspeceHasPlageViewModel(e, p, eDAO.densiteDAO, eDAO.populationTotaleDAO);
            return ep;
        }

        public static ObservableCollection<EspeceHasPlageViewModel> listeEspeceHasPlages()
        {
            ObservableCollection<EspeceHasPlageDAO> lDAO = EspeceHasPlageDAO.listeEspeceHasPlages();
            ObservableCollection<EspeceHasPlageViewModel> l = new ObservableCollection<EspeceHasPlageViewModel>();
            foreach (EspeceHasPlageDAO element in lDAO)
            {

                int Espece_idEspece = element.Espece_idEspeceDAO;
                EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

                int Plage_idPlage = element.Plage_idPlageDAO;
                PlageViewModel p = PlageORM.getPlage(Plage_idPlage);

                EspeceHasPlageViewModel ep = new EspeceHasPlageViewModel(e, p, element.densiteDAO, element.populationTotaleDAO);
                l.Add(ep);
            }
            return l;
        }
        public static void updateEspeceHasPlage(EspeceHasPlageViewModel ep)
        {
            EspeceHasPlageDAO.updateEspeceHasPlage(new EspeceHasPlageDAO(ep.Espece_EspeceHasPlageProperty.idEspeceProperty, ep.Plage_EspeceHasPlageProperty.idPlageProperty, ep.densiteProperty, ep.populationTotaleProperty));
        }

        public static void supprimerEspeceHasPlage(int idEspece, int idPlage)
        {
            EspeceHasPlageDAO.supprimerEspeceHasPlage(idEspece, idPlage);
        }
        public static void insertEspeceHasPlage(EspeceHasPlageViewModel ep)
        {
            EspeceHasPlageDAO.insertEspeceHasPlage(new EspeceHasPlageDAO(ep.Espece_EspeceHasPlageProperty.idEspeceProperty, ep.Plage_EspeceHasPlageProperty.idPlageProperty, ep.densiteProperty, ep.populationTotaleProperty));
        }
    }
}
