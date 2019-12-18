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
    public class PlageViewModel : INotifyPropertyChanged
    {
        private int idPlage;
        private string nomPlage;        
        public CommuneViewModel communePlage;
        public int nbEspecesDifferentes;
        public float surface;

        public PlageViewModel() { }

        public PlageViewModel(int id, string nom, CommuneViewModel communePlage, int nbEspecesDifferentes, float surface)
        {
            this.idPlage = id;
            this.nomPlage = nom;
            this.communePlage = communePlage;
            this.nbEspecesDifferentes = nbEspecesDifferentes;
            this.surface = surface;         
        }

        public int idPlageProperty
        {
            get { return idPlage; }
        }
        public string nomPlageProperty
        {
            get { return nomPlage; }
            set
            {
                this.nomPlage = value;
                OnPropertyChanged("nomPlageProperty");
            }
        }
        public CommuneViewModel communePlageProperty
        {
            get { return communePlage; }
        }
        public string CommunePlageNomProperty
        {
            get { return communePlage.nomCommuneProperty; }
        }
        public int nbEspecesDifferentesPlageProperty
        {
            get { return nbEspecesDifferentes; }
            set
            {
                this.nbEspecesDifferentes = value;
                OnPropertyChanged("nbEspecesDifferentesProperty");
            }
        }
        public float surfacePlageProperty
        {
            get { return surface; }
            set
            {
                this.surface = value;
                OnPropertyChanged("surfaceProperty");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                PlageORM.updatePlage(this);
            }
        }

    }
}
