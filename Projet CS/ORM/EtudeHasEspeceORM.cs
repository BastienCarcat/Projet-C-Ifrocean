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
    class EtudeHasEspeceORM
    {
        
        public static EtudeHasEspeceViewModel getEtudeHasEspece(int idEtude, int idEspece)
        {
            EtudeHasEspeceDAO eDAO = EtudeHasEspeceDAO.getEtudeHasEspece(idEtude, idEspece);

            int Etude_idEtude = eDAO.Etude_idEtudeDAO;
            EtudeViewModel et = EtudeORM.getEtude(Etude_idEtude);

            int Espece_idEspece = eDAO.Espece_idEspeceDAO;
            EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

            EtudeHasEspeceViewModel ee = new EtudeHasEspeceViewModel(et, e, eDAO.densiteTotaleEspeceDAO);
            return ee;
        }

        public static ObservableCollection<EtudeHasEspeceViewModel> listeEtudeHasEspeces()
        {
            ObservableCollection<EtudeHasEspeceDAO> lDAO = EtudeHasEspeceDAO.listeEtudeHasEspeces();
            ObservableCollection<EtudeHasEspeceViewModel> l = new ObservableCollection<EtudeHasEspeceViewModel>();
            foreach (EtudeHasEspeceDAO element in lDAO)
            {

                int Etude_idEtude = element.Etude_idEtudeDAO;
                EtudeViewModel et = EtudeORM.getEtude(Etude_idEtude);

                int Espece_idEspece = element.Espece_idEspeceDAO;
                EspeceViewModel e = EspeceORM.getEspece(Espece_idEspece);

                EtudeHasEspeceViewModel ee = new EtudeHasEspeceViewModel(et, e, element.densiteTotaleEspeceDAO);
                l.Add(ee);
            }
            return l;
        }
        public static void updateEtudeHasEspece(EtudeHasEspeceViewModel ee)
        {
            EtudeHasEspeceDAO.updateEtudeHasEspece(new EtudeHasEspeceDAO(ee.Etude_EtudeHasEspeceProperty.idEtudeProperty, ee.Espece_EtudeHasEspeceProperty.idEspeceProperty, ee.densiteTotaleEspeceProperty));
        }

        public static void supprimerEtudeHasEspece(int idEtude, int idEspece)
        {
            EtudeHasEspeceDAO.supprimerEtudeHasEspece(idEtude, idEspece);
        }
        public static void insertEtudeHasEspece(EtudeHasEspeceViewModel ee)
        {
            EtudeHasEspeceDAO.insertEtudeHasEspece(new EtudeHasEspeceDAO(ee.Etude_EtudeHasEspeceProperty.idEtudeProperty, ee.Espece_EtudeHasEspeceProperty.idEspeceProperty, ee.densiteTotaleEspeceProperty));
        }
    }
}
