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
    public class EspeceHasZoneViewModel : INotifyPropertyChanged
    {
        private EspeceViewModel idEspece;
        private ZoneViewModel idZone;
        private int nombreEspeceZone;        
        public EspeceHasZoneViewModel() { }

        public EspeceHasZoneViewModel(EspeceViewModel idEspece, ZoneViewModel idZone, int nombreEspeceZone)
        {
            this.idEspece = idEspece;
            this.idZone = idZone;
            this.nombreEspeceZone = nombreEspeceZone;            
        }

        public EspeceViewModel Espece_EspeceHasZoneProperty
        {
            get { return idEspece; }
            set
            {
                idEspece = value;
                //OnPropertyChanged("Espece_EspeceHasZoneProperty");
            }
        }
        public String EspeceName_EspeceHasZoneProperty
        {
            get { return idEspece.nomEspeceProperty; }
        }
        public ZoneViewModel Zone_EspeceHasZoneProperty
        {
            get { return idZone; }
            set
            {
                idZone = value;
                //    OnPropertyChanged("Zone_EspeceHasZoneProperty");
            }
        }
        public String ZoneName_EspeceHasZoneProperty
        {
            get { return idZone.nomZonePrelevementProperty; }
        }

        public int nombreEspeceZoneProperty
        {
            get { return nombreEspeceZone; }
            set
            {
                nombreEspeceZone = value;
                OnPropertyChanged("nombreEspeceZoneProperty");
            }
        }
     

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EspeceHasZoneORM.updateEspeceHasZone(this);
            }
        }

    }
}
