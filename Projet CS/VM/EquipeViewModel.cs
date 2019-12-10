using Projet_CS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.VM
{
    public class EquipeViewModel : INotifyPropertyChanged
    {
        private int idEquipe;
        private string nomEquipe;
        private int nombreMembresEquipe;

        public EquipeViewModel() { }

        public EquipeViewModel(int idEquipe, string nomEquipe, int nombreMembresEquipe)
        {
            this.idEquipe = idEquipe;
            this.nomEquipe = nomEquipe;
            this.nombreMembresEquipe = nombreMembresEquipe;
        }

        public int idEquipeProperty
        {
            get { return idEquipe; }
        }
        public string nomEquipeProperty
        {
            get { return nomEquipe; }
            set
            {
                this.nomEquipe = value;                              
                OnPropertyChanged("nomEquipeProperty");
            }
        }
        
        public int nombreMembresEquipeProperty
        {
            get { return nombreMembresEquipe; }
            set
            {
                this.nombreMembresEquipe = value;                
                OnPropertyChanged("nombreMembresEquipeProperty");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EquipeDAO.updateEquipe(this);
            }
        }
        
    }
}
