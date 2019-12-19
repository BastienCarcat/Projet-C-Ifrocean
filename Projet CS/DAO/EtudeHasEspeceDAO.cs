using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projet_CS.DAO
{
    public class EtudeHasEspeceDAO
    {
        public int Etude_idEtudeDAO;
        public int Espece_idEspeceDAO;
        public Decimal densiteTotaleEspeceDAO;

        public EtudeHasEspeceDAO(int idEtude, int idEspece, Decimal densiteTotaleEspece)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.Etude_idEtudeDAO = idEtude;
            this.Espece_idEspeceDAO = idEspece;
            this.densiteTotaleEspeceDAO = densiteTotaleEspece;
        }

        //public EtudeHasEspeceDAO(int idUtilisateur, int idEquipe, int idUtilisateurUpdate, int idEquipeUpdate)
        //{
        //    this.Utilisateur_idUtilisateurDAO = idUtilisateur;
        //    this.Equipe_idEquipeDAO = idEquipe;
        //    this.UtilisateurUpdate_idUtilisateurDAO = idUtilisateurUpdate;
        //    this.EquipeUpdate_idEquipeDAO = idEquipeUpdate;
        //}
        
        public static ObservableCollection<EtudeHasEspeceDAO> listeEtudeHasEspeces()
        {
            ObservableCollection<EtudeHasEspeceDAO> l = EtudeHasEspeceDAL.selectEtudeHasEspeces();
            return l;
        }
        //////
        //public static EtudeHasEspeceDAO getEtudeHasEspeceByEquipe(int idEquipe)
        //{
        //    EtudeHasEspeceDAO u = EtudeHasEspeceDAL.getEtudeHasEspeceByEquipe(idEquipe);
        //    return u;
        //}
        public static EtudeHasEspeceDAO getEtudeHasEspece(int idEtude, int idEspece)
        {
            EtudeHasEspeceDAO u = EtudeHasEspeceDAL.getEtudeHasEspece(idEtude, idEspece);
            return u;
        }
        
        public static void updateEtudeHasEspece(EtudeHasEspeceDAO u)
        {
            EtudeHasEspeceDAL.updateEtudeHasEspece(u);
        }

        public static void supprimerEtudeHasEspece(int idEtude, int idEspece)
        {
            EtudeHasEspeceDAL.supprimerEtudeHasEspece(idEtude, idEspece);
        }

        public static void insertEtudeHasEspece(EtudeHasEspeceDAO u)
        {
            EtudeHasEspeceDAL.insertEtudeHasEspece(u);
        }
    }
}
