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
            int idEquipe = eDAO.idEquipeEtudeDAO;
            EquipeViewModel m = EquipeORM.getEquipe(idEquipe);
            EtudeViewModel u = new EtudeViewModel(eDAO.idEtudeDAO, eDAO.dateEtudeDAO, eDAO.titreEtudeDAO, eDAO.nbTotalEspeceRencontreeEtudeDAO, m);
            return u;
        }

        public static ObservableCollection<EtudeViewModel> listeEtudes()
        {
            ObservableCollection<EtudeDAO> lDAO = EtudeDAO.listeEtudes();
            ObservableCollection<EtudeViewModel> l = new ObservableCollection<EtudeViewModel>();
            foreach (EtudeDAO element in lDAO)
            {
                int idEquipe = element.idEquipeEtudeDAO;
                EquipeViewModel m = EquipeORM.getEquipe(idEquipe);
                EtudeViewModel u = new EtudeViewModel(element.idEtudeDAO, element.dateEtudeDAO, element.titreEtudeDAO, element.nbTotalEspeceRencontreeEtudeDAO, m);
                l.Add(u);
            }
            return l;
        }
    }
}
