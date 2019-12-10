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
    public class UtilisateurViewModel : INotifyPropertyChanged
    {
        private int idUtilisateur;
        private string nomUtilisateur;
        private string prenomUtilisateur;
        private string passwordUtilisateur;
        private string loginUtilisateur;
        private byte isAdminUtilisateur;

        public UtilisateurViewModel() { }

        public UtilisateurViewModel(int id, string nom, string prenom, byte isAdmin, string password, string login)
        {
            this.idUtilisateur = id;
            this.nomUtilisateur = nom;
            this.prenomUtilisateur = prenom;
            this.isAdminUtilisateur = isAdmin;
            this.passwordUtilisateur = password;
            this.loginUtilisateur = login;
        }

        public int idUtilisateurProperty
        {
            get { return idUtilisateur; }
        }
        public string nomUtilisateurProperty
        {
            get { return nomUtilisateur; }
            set
            {
                nomUtilisateur = value.ToUpper();                
                OnPropertyChanged("nomUtilisateurProperty");
            }
        }
        public string prenomUtilisateurProperty
        {
            get { return prenomUtilisateur; }
            set
            {
                this.prenomUtilisateur = value;                
                OnPropertyChanged("prenomUtilisateurProperty");
            }
        }
        public string passwordUtilisateurProperty
        {
            get { return passwordUtilisateur; }
            set
            {
                this.passwordUtilisateur = value;                
                OnPropertyChanged("passwordUtilisateurProperty");
            }
        }
        public string loginUtilisateurProperty
        {
            get { return loginUtilisateur; }
            set
            {
                this.loginUtilisateur = value;               
                OnPropertyChanged("loginUtilisateurProperty");
            }
        }
        public byte isAdminUtilisateurProperty
        {
            get { return isAdminUtilisateur; }
            set
            {
                this.isAdminUtilisateur = value;                
                OnPropertyChanged("isAdminUtilisateurProperty");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                UtilisateurDAO.updateUtilisateur(this);
            }
        }
      
    }
}
