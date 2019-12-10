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
            PlageViewModel u = new PlageViewModel(pDAO.idPlageDAO, pDAO.nomPlageDAO, pDAO.idCommuneDAO, pDAO.nbEspecesDifferentesDAO, pDAO.surfaceDAO);
            return u;
        }

        public static ObservableCollection<PlageViewModel> listePlages()
        {
            ObservableCollection<PlageDAO> lDAO = PlageDAO.listePlages();
            ObservableCollection<PlageViewModel> l = new ObservableCollection<PlageViewModel>();
            foreach (PlageDAO element in lDAO)
            {
                PlageViewModel u = new PlageViewModel(element.idPlageDAO, element.nomPlageDAO, element.idCommuneDAO, element.nbEspecesDifferentesDAO, element.surfaceDAO);
                l.Add(u);
            }
            return l;
        }
    }
}
