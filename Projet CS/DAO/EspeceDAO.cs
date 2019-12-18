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
    public class EspeceDAO
    {
        public int idEspeceDAO;
        public string nomEspeceDAO;

        public EspeceDAO(int idEspeceDAO, string nomEspeceDAO)
        {
            this.idEspeceDAO = idEspeceDAO;
            this.nomEspeceDAO = nomEspeceDAO;

        }
        public static ObservableCollection<EspeceDAO> listeEspeces()
        {
            ObservableCollection<EspeceDAO> l = EspeceDAL.selectEspeces();
            return l;
        }

        public static EspeceDAO getEspeces(int idEspece)
        {
            EspeceDAO e = EspeceDAL.getEspece(idEspece);
            return e;
        }

        public static void updateEspece(EspeceDAO esp)
        {
            EspeceDAL.updateEspece(esp);
        }

        public static void supprimerEspece(int idEspece)
        {
            EspeceDAL.supprimerEspece(idEspece);
        }

        public static void insertEspece(EspeceDAO esp)
        {
            EspeceDAL.insertEspece(esp);
        }
    }
}
