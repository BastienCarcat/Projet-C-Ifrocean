using Projet_CS.DAO;
using Projet_CS.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.VM
{
    public class DepartementViewModel : INotifyPropertyChanged
    {
        private int idDepartement;
        private string nomDepartement;        

        public DepartementViewModel() { }

        public DepartementViewModel(int idDepartement, string nomDepartement)
        {
            this.idDepartement = idDepartement;
            this.nomDepartement = nomDepartement;            
        }

        public int idDepartementProperty
        {
            get { return idDepartement; }
        }
        public string nomDepartementProperty
        {
            get { return nomDepartement; }
            set
            {
                this.nomDepartement = value;
                OnPropertyChanged("nomDepartementProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                DepartementORM.updateDepartement(this);
            }
        }

    }
}
