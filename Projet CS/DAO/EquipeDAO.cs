using Projet_CS.DAL;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.DAO
{
    public class EquipeDAO
    {
        public int idEquipeDAO;
        public string nomEquipeDAO;
        public int nombreMembresEquipeDAO;
        public EquipeDAO(int idEquipeDAO, string nomEquipeDAO, int nombreMembresEquipeDAO)
        {
            this.idEquipeDAO = idEquipeDAO;
            this.nomEquipeDAO = nomEquipeDAO;
            this.nombreMembresEquipeDAO = nombreMembresEquipeDAO;            
        }
        public static ObservableCollection<EquipeDAO> listeEquipes()
        {
            ObservableCollection<EquipeDAO> l = EquipeDAL.selectEquipes();
            return l;
        }

        public static EquipeDAO getEquipes(int idEquipe)
        {
            EquipeDAO e = EquipeDAL.getEquipe(idEquipe);
            return e;
        }

        public static void updateEquipe(EquipeViewModel e)
        {
            EquipeDAL.updateEquipe(new EquipeDAO(e.idEquipeProperty, e.nomEquipeProperty, e.nombreMembresEquipeProperty));
        }

        public static void supprimerEquipe(int id)
        {
            EquipeDAL.supprimerEquipe(id);
        }

        public static void insertEquipe(EquipeViewModel e)
        {
            EquipeDAL.insertEquipe(new EquipeDAO(e.idEquipeProperty, e.nomEquipeProperty, e.nombreMembresEquipeProperty));
        }
    }
}
