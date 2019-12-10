using Projet_CS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CS.VM
{
    public class EspeceViewModel : INotifyPropertyChanged
    {
        private int idEspece;
        private string nomEspece;

        public EspeceViewModel() { }

        public EspeceViewModel(int idEspece, string nomEspece)
        {
            this.idEspece = idEspece;
            this.nomEspece = nomEspece;
        }

        public int idEspeceProperty
        {
            get { return idEspece; }
        }
        public string nomEspeceProperty
        {
            get { return nomEspece; }
            set
            {
                this.nomEspece = value;
                OnPropertyChanged("nomEspeceProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EspeceDAO.updateEspece(this);
            }
        }

    }
}
