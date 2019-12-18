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
    class EspeceORM
    {
        public static EspeceViewModel getEspece(int idEspece)
        {
            EspeceDAO dDAO = EspeceDAO.getEspeces(idEspece);
            EspeceViewModel e = new EspeceViewModel(dDAO.idEspeceDAO, dDAO.nomEspeceDAO);
            return e;
        }

        public static ObservableCollection<EspeceViewModel> listeEspeces()
        {
            ObservableCollection<EspeceDAO> lDAO = EspeceDAO.listeEspeces();
            ObservableCollection<EspeceViewModel> l = new ObservableCollection<EspeceViewModel>();
            foreach (EspeceDAO element in lDAO)
            {
                EspeceViewModel e = new EspeceViewModel(element.idEspeceDAO, element.nomEspeceDAO);
                l.Add(e);
            }
            return l;
        }
        public static void updateEspece(EspeceViewModel p)
        {
            EspeceDAO.updateEspece(new EspeceDAO(p.idEspeceProperty, p.nomEspeceProperty));
        }

        public static void supprimerEspece(int id)
        {
            EspeceDAO.supprimerEspece(id);
        }

        public static void insertEspece(EspeceViewModel p)
        {
            EspeceDAO.insertEspece(new EspeceDAO(p.idEspeceProperty, p.nomEspeceProperty));
        }
    }
}
