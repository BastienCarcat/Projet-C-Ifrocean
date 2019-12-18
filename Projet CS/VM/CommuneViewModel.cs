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
    public class CommuneViewModel : INotifyPropertyChanged
    {
        private int idCommune;
        private string nomCommune;
        public DepartementViewModel departementCommune;
        public CommuneViewModel() { }

        public CommuneViewModel(int idCommune, string nomCommune, DepartementViewModel departementCommune)
        {
            this.idCommune = idCommune;
            this.nomCommune = nomCommune;
            this.departementCommune = departementCommune;
        }

        public int idCommuneProperty
        {
            get { return idCommune; }
        }
        public string nomCommuneProperty
        {
            get { return nomCommune; }
            set
            {
                this.nomCommune = value;
                OnPropertyChanged("nomCommuneProperty");
            }
        }
        public DepartementViewModel departementCommuneProperty
        {   
            get { return departementCommune; }
        }
        public string departementCommuneNameProperty
        {
            get { return departementCommune.nomDepartementProperty; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                CommuneORM.updateCommune(this);
            }
        }

    }
}
