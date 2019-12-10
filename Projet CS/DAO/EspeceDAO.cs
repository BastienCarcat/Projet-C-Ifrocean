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

        public static void updateEspece(EspeceViewModel e)
        {
            EspeceDAL.updateEspece(new EspeceDAO(e.idEspeceProperty, e.nomEspeceProperty));
        }

        public static void supprimerEspece(int id)
        {
            EspeceDAL.supprimerEspece(id);
        }

        public static void insertEspece(EspeceViewModel e)
        {
            EspeceDAL.insertEspece(new EspeceDAO(e.idEspeceProperty, e.nomEspeceProperty));
        }
    }
}
