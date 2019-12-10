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
    class UtilisateurORM
    {
        public static UtilisateurViewModel getUtilisateur(int idUtilisateur)
        {
            UtilisateurDAO uDAO = UtilisateurDAO.getUtilisateurs(idUtilisateur);
            UtilisateurViewModel u = new UtilisateurViewModel(uDAO.idUtilisateurDAO, uDAO.nomUtilisateurDAO, uDAO.prenomUtilisateurDAO, uDAO.isAdminUtilisateurDAO, uDAO.passwordUtilisateurDAO, uDAO.loginUtilisateurDAO);
            return u;
        }

        public static ObservableCollection<UtilisateurViewModel> listeUtilisateurs()
        {
            ObservableCollection<UtilisateurDAO> lDAO = UtilisateurDAO.listeUtilisateurs();
            ObservableCollection<UtilisateurViewModel> l = new ObservableCollection<UtilisateurViewModel>();
            foreach (UtilisateurDAO element in lDAO)
            {
                UtilisateurViewModel u = new UtilisateurViewModel(element.idUtilisateurDAO, element.nomUtilisateurDAO, element.prenomUtilisateurDAO, element.isAdminUtilisateurDAO, element.passwordUtilisateurDAO, element.loginUtilisateurDAO);
                l.Add(u);
            }
            return l;
        }
    }
}
