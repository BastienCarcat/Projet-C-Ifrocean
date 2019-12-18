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
    class CommuneORM
    {
        public static CommuneViewModel getCommune(int idCommune)
        {
            CommuneDAO cDAO = CommuneDAO.getCommunes(idCommune);
            int idDepartement = cDAO.idDepartementDAO;
            DepartementViewModel m = DepartementORM.getDepartement(idDepartement);
            CommuneViewModel e = new CommuneViewModel(cDAO.idCommuneDAO, cDAO.nomCommuneDAO, m);
            return e;
        }

        public static ObservableCollection<CommuneViewModel> listeCommunes()
        {
            ObservableCollection<CommuneDAO> lDAO = CommuneDAO.listeCommunes();
            ObservableCollection<CommuneViewModel> l = new ObservableCollection<CommuneViewModel>();
            foreach (CommuneDAO element in lDAO)
            {
                int idDepartement = element.idDepartementDAO;

                DepartementViewModel m = DepartementORM.getDepartement(idDepartement); // Plus propre que d'aller chercher le departement dans la DAO.
                CommuneViewModel e = new CommuneViewModel(element.idCommuneDAO, element.nomCommuneDAO, m);
                l.Add(e);
            }
            return l;
        }

        public static void updateCommune(CommuneViewModel p)
        {
            CommuneDAO.updateCommune(new CommuneDAO(p.idCommuneProperty, p.nomCommuneProperty, p.departementCommune.idDepartementProperty));
        }

        public static void supprimerCommune(int id)
        {
            CommuneDAO.supprimerCommune(id);
        }

        public static void insertCommune(CommuneViewModel p)
        {
            CommuneDAO.insertCommune(new CommuneDAO(p.idCommuneProperty, p.nomCommuneProperty, p.departementCommune.idDepartementProperty));
        }
    }
}
