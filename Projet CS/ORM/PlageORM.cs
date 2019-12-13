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
    class PlageORM
    {
        public static PlageViewModel getPlage(int idPlage)
        {
            PlageDAO pDAO = PlageDAO.getPlages(idPlage);
            int idCommune = pDAO.idCommuneDAO;

            CommuneViewModel m = CommuneORM.getCommune(idCommune); // Plus propre que d'aller chercher la commune dans la DAO.
            PlageViewModel u = new PlageViewModel(pDAO.idPlageDAO, pDAO.nomPlageDAO, m, pDAO.nbEspecesDifferentesDAO, pDAO.surfaceDAO);
            return u;
        }

        public static ObservableCollection<PlageViewModel> listePlages()
        {
            ObservableCollection<PlageDAO> lDAO = PlageDAO.listePlages();
            ObservableCollection<PlageViewModel> l = new ObservableCollection<PlageViewModel>();
            foreach (PlageDAO element in lDAO)
            {
                int idCommune = element.idCommuneDAO;

                CommuneViewModel m = CommuneORM.getCommune(idCommune); // Plus propre que d'aller chercher la commune dans la DAO.
                PlageViewModel u = new PlageViewModel(element.idPlageDAO, element.nomPlageDAO, m, element.nbEspecesDifferentesDAO, element.surfaceDAO);
                l.Add(u);
            }
            return l;
        }
    }
}
