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
        

        public UtilisateurHasEquipeDAO(int idUtilisateur, int idEquipe)
        {
            this.Utilisateur_idUtilisateurDAO = idUtilisateur;
            this.Equipe_idEquipeDAO = idEquipe;            
        }

        public static ObservableCollection<UtilisateurHasEquipeDAO> listeUtilisateurHasEquipes()
        {
            ObservableCollection<UtilisateurHasEquipeDAO> l = UtilisateurHasEquipeDAL.selectUtilisateurHasEquipes();
            return l;
        }


        public static UtilisateurHasEquipeDAO getUtilisateurHasEquipe(int idUtilisateur, int idEquipe)
        {
            UtilisateurHasEquipeDAO u = UtilisateurHasEquipeDAL.getUtilisateurHasEquipe(idUtilisateur, idEquipe);
            return u;
        }

        //pas de update clés primaires

        //public static void updateUtilisateur(UtilisateurHasEquipeDAO u)
        //{
        //    UtilisateurDAL.updateUtilisateur(u);
        //}

        public static void supprimerUtilisateurHasEquipe(int idUtilisateur, int idEquipe)
        {
            UtilisateurHasEquipeDAL.supprimerUtilisateurHasEquipe(idUtilisateur, idEquipe);
        }

        public static void insertUtilisateurHasEquipe(UtilisateurHasEquipeDAO u)
        {
            UtilisateurHasEquipeDAL.insertUtilisateurHasEquipe(u);
        }
    }
}
