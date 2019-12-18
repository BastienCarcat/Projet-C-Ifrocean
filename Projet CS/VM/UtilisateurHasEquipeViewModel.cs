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
        private int Utilisateur_idUtilisateur;
        private int Equipe_idEquipe;        

        public UtilisateurHasEquipeViewModel() { }

        public UtilisateurHasEquipeViewModel(int idUtilisateur, int idEquipe)
        {
            this.Utilisateur_idUtilisateur = idUtilisateur;
            this.Equipe_idEquipe = idEquipe;
        }

        //public int idUtilisateurHasEquipeProperty
        //{
        //    get { return idUtilisateurHasEquipe; }
        //}        
        public int Utilisateur_idUtilisateurHasEquipeProperty
        {
            get { return Utilisateur_idUtilisateur; }
            set
            {
                this.Utilisateur_idUtilisateur = value;
                OnPropertyChanged("Utilisateur_idUtilisateurHasEquipeProperty");
            }
        }
        public int Equipe_idUtilisateurHasEquipeProperty
        {
            get { return Equipe_idEquipe; }
            set
            {
                this.Equipe_idEquipe = value;
                OnPropertyChanged("Equipe_idUtilisateurHasEquipeProperty");
            }
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
