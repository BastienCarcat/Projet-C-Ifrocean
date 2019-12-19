using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Projet_CS.ORM;
using Projet_CS.DAO;
using System.Globalization;
using System.Threading;

namespace Projet_CS.VM
{
    public class EtudeHasEspeceViewModel : INotifyPropertyChanged
    {
        private EtudeViewModel idEtude;
        private EspeceViewModel idEspece;
        private Decimal densiteTotaleEspece;

        public EtudeHasEspeceViewModel() { }

        public EtudeHasEspeceViewModel(EtudeViewModel idEtude, EspeceViewModel idEspece, Decimal densiteTotaleEspece)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.idEtude = idEtude;
            this.idEspece = idEspece;
            this.densiteTotaleEspece = densiteTotaleEspece;
        }

        public EtudeViewModel Etude_EtudeHasEspeceProperty
        {
            get { return idEtude; }
            set
            {
                idEtude = value;
                //OnPropertyChanged("Etude_EtudeHasEspeceProperty");
            }
        }
        public String EtudeName_EtudeHasEspeceProperty
        {
            get { return idEtude.titreEtudeProperty; }
        }
        public EspeceViewModel Espece_EtudeHasEspeceProperty
        {
            get { return idEspece; }
            set
            {
                idEspece = value;
                //    OnPropertyChanged("Espece_EtudeHasEspeceProperty");
            }
        }
        public String EspeceName_EtudeHasEspeceProperty
        {
            get { return idEspece.nomEspeceProperty; }
        }

        public Decimal densiteTotaleEspeceProperty
        {
            get { return densiteTotaleEspece; }
            set
            {
                densiteTotaleEspece = value;
                OnPropertyChanged("densiteTotaleEspeceProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EtudeHasEspeceORM.updateEtudeHasEspece(this);                
            }
        }

    }
}
