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
    public class EtudeHasPlageViewModel : INotifyPropertyChanged
    {
        private EtudeViewModel idEtude;
        private PlageViewModel idPlage;
        private ZoneViewModel idZone;
        private string name_concatenation;
        

        public EtudeHasPlageViewModel() { }

        public EtudeHasPlageViewModel(EtudeViewModel idEtude, PlageViewModel idPlage, ZoneViewModel idZone, string name_concatenation)
        {
            this.idEtude = idEtude;
            this.idPlage = idPlage;
            this.idZone = idZone;
            this.name_concatenation = name_concatenation;
        }

        public EtudeViewModel Etude_EtudeHasPlageProperty
        {
            get { return idEtude; }
            set
            {
                idEtude = value;
                //OnPropertyChanged("Etude_EtudeHasPlageProperty");
            }
        }
        public String EtudeName_EtudeHasPlageProperty
        {
            get { return idEtude.titreEtudeProperty; }
        }
        public PlageViewModel Plage_EtudeHasPlageProperty
        {
            get { return idPlage; }
            set
            {
                idPlage = value;
                //    OnPropertyChanged("Plage_EtudeHasPlageProperty");
            }
        }
        public String PlageName_EtudeHasPlageProperty
        {
            get { return idPlage.nomPlageProperty; }
        }

        public ZoneViewModel Zone_EtudeHasPlageProperty
        {
            get { return idZone; }
            set
            {
                idZone = value;
                //    OnPropertyChanged("Plage_EtudeHasPlageProperty");
            }
        }
        public String ZoneName_EtudeHasPlageProperty
        {
            get { return idZone.nomZonePrelevementProperty; }
        }

        public string name_concatenationProperty
        {
            get { return name_concatenation; }
            set
            {
                name_concatenation = value;
                OnPropertyChanged("name_concatenationProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EtudeHasPlageORM.updateEtudeHasPlage(this);
            }
        }

    }
}
