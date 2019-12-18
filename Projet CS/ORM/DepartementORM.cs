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
    class DepartementORM
    {
        public static DepartementViewModel getDepartement(int idDepartement)
        {
            DepartementDAO dDAO = DepartementDAO.getDepartements(idDepartement);
            DepartementViewModel e = new DepartementViewModel(dDAO.idDepartementDAO, dDAO.nomDepartementDAO);
            return e;
        }        
        public static ObservableCollection<DepartementViewModel> listeDepartements()
        {
            ObservableCollection<DepartementDAO> lDAO = DepartementDAO.listeDepartements();
            ObservableCollection<DepartementViewModel> l = new ObservableCollection<DepartementViewModel>();
            foreach (DepartementDAO element in lDAO)
            {
                DepartementViewModel e = new DepartementViewModel(element.idDepartementDAO, element.nomDepartementDAO);
                l.Add(e);
            }
            return l;
        }
        public static void updateDepartement(DepartementViewModel p)
        {
            DepartementDAO.updateDepartement(new DepartementDAO(p.idDepartementProperty, p.nomDepartementProperty));
        }

        public static void supprimerDepartement(int id)
        {
            DepartementDAO.supprimerDepartement(id);
        }

        public static void insertDepartement(DepartementViewModel p)
        {
            DepartementDAO.insertDepartement(new DepartementDAO(p.idDepartementProperty, p.nomDepartementProperty));
        }
    }
}
