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
    public class DepartementDAO
    {
        public int idDepartementDAO;
        public string nomDepartementDAO;
        
        public DepartementDAO(int idDepartementDAO, string nomDepartementDAO)
        {
            this.idDepartementDAO = idDepartementDAO;
            this.nomDepartementDAO = nomDepartementDAO;
            
        }
        public static ObservableCollection<DepartementDAO> listeDepartements()
        {
            ObservableCollection<DepartementDAO> l = DepartementDAL.selectDepartements();
            return l;
        }

        public static DepartementDAO getDepartements(int idDepartement)
        {
            DepartementDAO e = DepartementDAL.getDepartement(idDepartement);
            return e;
        }
        //public static DepartementDAO getDepartementsName()
        //{
        //    DepartementDAO e = DepartementDAL.getDepartementName();
        //    return e;
        //}
        public static void updateDepartement(DepartementViewModel e)
        {
            DepartementDAL.updateDepartement(new DepartementDAO(e.idDepartementProperty, e.nomDepartementProperty));
        }

        public static void supprimerDepartement(int id)
        {
            DepartementDAL.supprimerDepartement(id);
        }

        public static void insertDepartement(DepartementViewModel e)
        {
            DepartementDAL.insertDepartement(new DepartementDAO(e.idDepartementProperty, e.nomDepartementProperty));
        }
    }
}
