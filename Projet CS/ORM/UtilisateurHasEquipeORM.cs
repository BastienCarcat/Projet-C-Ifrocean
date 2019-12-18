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
    class UtilisateurHasEquipeORM
    {
        //public static UtilisateurHasEquipeViewModel getUtilisateurHasEquipeByEquipe(int idEquipe)
        //{
        //    UtilisateurHasEquipeDAO uDAO = UtilisateurHasEquipeDAO.getUtilisateurHasEquipeByEquipe(idEquipe);
        //    UtilisateurHasEquipeViewModel u = new UtilisateurHasEquipeViewModel(uDAO.Utilisateur_idUtilisateurDAO, uDAO.Equipe_idEquipeDAO);
        //    return u;
        //}
        //public static UtilisateurHasEquipeViewModel getUtilisateurHasEquipeByUtilisateur(int idUtilisateur)
        //{
        //    UtilisateurHasEquipeDAO uDAO = UtilisateurHasEquipeDAO.getUtilisateurHasEquipeByUtilisateur(idUtilisateur);
        //    UtilisateurHasEquipeViewModel u = new UtilisateurHasEquipeViewModel(uDAO.Utilisateur_idUtilisateurDAO, uDAO.Equipe_idEquipeDAO);
        //    return u;
        //}

        //public static ObservableCollection<UtilisateurHasEquipeViewModel> listeUtilisateurHasEquipes()
        //{
        //    ObservableCollection<UtilisateurHasEquipeDAO> lDAO = UtilisateurHasEquipeDAO.listeUtilisateurHasEquipes();
        //    ObservableCollection<UtilisateurHasEquipeViewModel> l = new ObservableCollection<UtilisateurHasEquipeViewModel>();
        //    foreach (UtilisateurHasEquipeDAO element in lDAO)
        //    {
        //        UtilisateurHasEquipeViewModel u = new UtilisateurHasEquipeViewModel(element.Utilisateur_idUtilisateurDAO, element.Equipe_idEquipeDAO);
        //        l.Add(u);
        //    }
        //    return l;
        //}
    }
}
