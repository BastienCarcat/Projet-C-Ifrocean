using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Projet_CS.ORM;
using Projet_CS.DAO;

namespace Projet_CS.VM
{
    public class UtilisateurHasEquipeViewModel : INotifyPropertyChanged
    {        
        private UtilisateurViewModel idUtilisateur;
        private EquipeViewModel idEquipe;

        public UtilisateurHasEquipeViewModel() { }

        public UtilisateurHasEquipeViewModel(UtilisateurViewModel idUtilisateur, EquipeViewModel idEquipe)
        {
            this.idUtilisateur = idUtilisateur;
            this.idEquipe = idEquipe;
        }

        public UtilisateurViewModel Utilisateur_UtilisateurHasEquipeProperty
        {
            get { return idUtilisateur; }
            set
            {
                idUtilisateur = value;
                OnPropertyChanged("Utilisateur_UtilisateurHasEquipeProperty");
            }
        }
        public String UtilisateurName_UtilisateurHasEquipeProperty
        {
            get { return idUtilisateur.loginUtilisateurProperty; }
        }
        public EquipeViewModel Equipe_UtilisateurHasEquipeProperty
        {
            get { return idEquipe; }
            set
            {
                idEquipe = value;
                OnPropertyChanged("Equipe_UtilisateurHasEquipeProperty");
            }
        }
        public String EquipeName_UtilisateurHasEquipeProperty
        {
            get { return idEquipe.nomEquipeProperty; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                UtilisateurHasEquipeDAO.updateUtilisateurHasEquipe(this);                
            }
        }

    }
}
