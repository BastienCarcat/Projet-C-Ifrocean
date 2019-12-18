using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.DAO
{
    public class UtilisateurHasEquipeDAO
    {
        public int Utilisateur_idUtilisateurDAO;       
        public int Equipe_idEquipeDAO;       
        public int UtilisateurUpdate_idUtilisateurDAO;       
        public int EquipeUpdate_idEquipeDAO;

        public UtilisateurHasEquipeDAO(int idUtilisateur, int idEquipe)
        {
            this.Utilisateur_idUtilisateurDAO = idUtilisateur;
            this.Equipe_idEquipeDAO = idEquipe;            
        }

        public UtilisateurHasEquipeDAO(int idUtilisateur, int idEquipe, int idUtilisateurUpdate, int idEquipeUpdate)
        {
            this.Utilisateur_idUtilisateurDAO = idUtilisateur;
            this.Equipe_idEquipeDAO = idEquipe;
            this.UtilisateurUpdate_idUtilisateurDAO = idUtilisateurUpdate;
            this.EquipeUpdate_idEquipeDAO = idEquipeUpdate;
        }

        //////?
        public static ObservableCollection<UtilisateurHasEquipeDAO> listeUtilisateurHasEquipes()
        {
            ObservableCollection<UtilisateurHasEquipeDAO> l = UtilisateurHasEquipeDAL.selectUtilisateurHasEquipes();
            return l;
        }
        //////
        public static UtilisateurHasEquipeDAO getUtilisateurHasEquipeByEquipe(int idEquipe)
        {
            UtilisateurHasEquipeDAO u = UtilisateurHasEquipeDAL.getUtilisateurHasEquipeByEquipe(idEquipe);
            return u;
        }
        public static UtilisateurHasEquipeDAO getUtilisateurHasEquipeByUtilisateur(int idUtilisateur)
        {
            UtilisateurHasEquipeDAO u = UtilisateurHasEquipeDAL.getUtilisateurHasEquipeByUtilisateur(idUtilisateur);
            return u;
        }

        public static void updateUtilisateurHasEquipe(UtilisateurHasEquipeViewModel u)
        {
            UtilisateurHasEquipeDAL.updateUtilisateurHasEquipe(new UtilisateurHasEquipeDAO(u.Utilisateur_idUtilisateurHasEquipeProperty, u.Equipe_idUtilisateurHasEquipeProperty, u.UtilisateurUpdate_idUtilisateurHasEquipeProperty, u.EquipeUpdate_idUtilisateurHasEquipeProperty));
        }

        public static void supprimerUtilisateurHasEquipe(int idUtilisateur, int idEquipe)
        {
            UtilisateurHasEquipeDAL.supprimerUtilisateurHasEquipe(idUtilisateur, idEquipe);
        }

        public static void insertUtilisateurHasEquipe(UtilisateurHasEquipeViewModel u)
        {
            UtilisateurHasEquipeDAL.insertUtilisateurHasEquipe(new UtilisateurHasEquipeDAO(u.Utilisateur_idUtilisateurHasEquipeProperty, u.Equipe_idUtilisateurHasEquipeProperty));
        }
    }
}
