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
    class EquipeORM
    {
        public static EquipeViewModel getEquipe(int idEquipe)
        {
            EquipeDAO eDAO = EquipeDAO.getEquipes(idEquipe);
            EquipeViewModel e = new EquipeViewModel(eDAO.idEquipeDAO, eDAO.nomEquipeDAO, eDAO.nombreMembresEquipeDAO);
            return e;
        }

        public static ObservableCollection<EquipeViewModel> listeEquipes()
        {
            ObservableCollection<EquipeDAO> lDAO = EquipeDAO.listeEquipes();
            ObservableCollection<EquipeViewModel> l = new ObservableCollection<EquipeViewModel>();
            foreach (EquipeDAO element in lDAO)
            {
                EquipeViewModel e = new EquipeViewModel(element.idEquipeDAO, element.nomEquipeDAO, element.nombreMembresEquipeDAO);
                l.Add(e);
            }
            return l;
        }
        public static void updateEquipe(EquipeViewModel p)
        {
            EquipeDAO.updateEquipe(new EquipeDAO(p.idEquipeProperty, p.nomEquipeProperty, p.nombreMembresEquipeProperty));
        }

        public static void supprimerEquipe(int id)
        {
            EquipeDAO.supprimerEquipe(id);
        }

        public static void insertEquipe(EquipeViewModel p)
        {
            EquipeDAO.insertEquipe(new EquipeDAO(p.idEquipeProperty, p.nomEquipeProperty, p.nombreMembresEquipeProperty));
        }
    }
}
