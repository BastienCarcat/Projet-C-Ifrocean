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
        private int EquipeUpdate_idEquipe;        
        private int UtilisateurUpdate_idUtilisateur;        

        public UtilisateurHasEquipeViewModel() { }

        public UtilisateurHasEquipeViewModel(int idUtilisateur, int idEquipe)
        {
            this.Utilisateur_idUtilisateur = idUtilisateur;
            this.Equipe_idEquipe = idEquipe;
        }

        public UtilisateurHasEquipeViewModel(int idUtilisateur, int idEquipe, int idUtilisateurUpdate, int idEquipeUpdate)
        {
            this.Utilisateur_idUtilisateur = idUtilisateur;
            this.Equipe_idEquipe = idEquipe;
            this.UtilisateurUpdate_idUtilisateur = idUtilisateurUpdate;
            this.EquipeUpdate_idEquipe = idEquipeUpdate;
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
        public int EquipeUpdate_idUtilisateurHasEquipeProperty
        {
            get { return EquipeUpdate_idEquipe; }
            set
            {
                this.EquipeUpdate_idEquipe = value;
                OnPropertyChanged("EquipeUpdate_idUtilisateurHasEquipeProperty");
            }
        }
        public int UtilisateurUpdate_idUtilisateurHasEquipeProperty
        {
            get { return UtilisateurUpdate_idUtilisateur; }
            set
            {
                this.UtilisateurUpdate_idUtilisateur = value;
                OnPropertyChanged("UtilisateurUpdate_idUtilisateurHasEquipeProperty");
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
