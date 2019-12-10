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
    class EtudeORM
    {
        public static EtudeViewModel getEtude(int idEtude)
        {
            EtudeDAO eDAO = EtudeDAO.getEtudes(idEtude);
            EtudeViewModel u = new EtudeViewModel(eDAO.idEtudeDAO, eDAO.dateEtudeDAO, eDAO.titreEtudeDAO, eDAO.nbTotalEspeceRencontreeEtudeDAO, eDAO.idEquipeEtudeDAO);
            return u;
        }

        public static ObservableCollection<EtudeViewModel> listeEtudes()
        {
            ObservableCollection<EtudeDAO> lDAO = EtudeDAO.listeEtudes();
            ObservableCollection<EtudeViewModel> l = new ObservableCollection<EtudeViewModel>();
            foreach (EtudeDAO element in lDAO)
            {
                EtudeViewModel u = new EtudeViewModel(element.idEtudeDAO, element.dateEtudeDAO, element.titreEtudeDAO, element.nbTotalEspeceRencontreeEtudeDAO, element.idEquipeEtudeDAO);
                l.Add(u);
            }
            return l;
        }
    }
}
