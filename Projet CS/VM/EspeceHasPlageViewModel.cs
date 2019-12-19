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
    public class EspeceHasPlageViewModel : INotifyPropertyChanged
    {
        private EspeceViewModel idEspece;
        private PlageViewModel idPlage;
        private Decimal densite;
        private Decimal populationTotale;


        public EspeceHasPlageViewModel() { }

        public EspeceHasPlageViewModel(EspeceViewModel idEspece, PlageViewModel idPlage, Decimal densite, Decimal populationTotale)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.idEspece = idEspece;
            this.idPlage = idPlage;
            this.densite = densite;
            this.populationTotale = populationTotale;
        }

        public EspeceViewModel Espece_EspeceHasPlageProperty
        {
            get { return idEspece; }
            set
            {
                idEspece = value;
                //OnPropertyChanged("Espece_EspeceHasPlageProperty");
            }
        }
        public String EspeceName_EspeceHasPlageProperty
        {
            get { return idEspece.nomEspeceProperty; }
        }
        public PlageViewModel Plage_EspeceHasPlageProperty
        {
            get { return idPlage; }
            set
            {
                idPlage = value;
                //    OnPropertyChanged("Plage_EspeceHasPlageProperty");
            }
        }
        public String PlageName_EspeceHasPlageProperty
        {
            get { return idPlage.nomPlageProperty; }
        }

        public Decimal densiteProperty
        {
            get { return densite; }
            set
            {
                densite = value;
                OnPropertyChanged("densiteProperty");
            }
        }

        public Decimal populationTotaleProperty
        {
            get { return populationTotale; }
            set
            {
                populationTotale = value;
                OnPropertyChanged("populationTotaleProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EspeceHasPlageORM.updateEspeceHasPlage(this);
            }
        }

    }
}
