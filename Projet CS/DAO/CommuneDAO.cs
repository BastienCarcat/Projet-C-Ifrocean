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
    public class CommuneDAO
    {
        public int idCommuneDAO;
        public string nomCommuneDAO;
        public int idDepartementDAO;
        public CommuneDAO(int idCommuneDAO, string nomCommuneDAO, int idDepartementDAO)
        {
            this.idCommuneDAO = idCommuneDAO;
            this.nomCommuneDAO = nomCommuneDAO;
            this.idDepartementDAO = idDepartementDAO;

        }
        public static ObservableCollection<CommuneDAO> listeCommunes()
        {
            ObservableCollection<CommuneDAO> l = CommuneDAL.selectCommunes();
            return l;
        }

        public static CommuneDAO getCommunes(int idCommune)
        {
            CommuneDAO e = CommuneDAL.getCommune(idCommune);
            return e;
        }

        public static void updateCommune(CommuneViewModel e)
        {
            CommuneDAL.updateCommune(new CommuneDAO(e.idCommuneProperty, e.nomCommuneProperty, e.departementCommuneProperty.idDepartementProperty));
        }

        public static void supprimerCommune(int id)
        {
            CommuneDAL.supprimerCommune(id);
        }

        public static void insertCommune(CommuneViewModel e)
        {
            CommuneDAL.insertCommune(new CommuneDAO(e.idCommuneProperty, e.nomCommuneProperty, e.departementCommuneProperty.idDepartementProperty));
        }
    }
}
