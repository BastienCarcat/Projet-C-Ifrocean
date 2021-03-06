﻿using Projet_CS.DAO;
using System;
using Projet_CS.ORM;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projet_CS.VM
{
    public class ZoneViewModel : INotifyPropertyChanged
    {
        private int idZonePrelevement;
        private string nomZonePrelevement;
        private Decimal lat1;
        private Decimal lat2;
        private Decimal lat3;
        private Decimal lat4;
        private Decimal long1;
        private Decimal long2;
        private Decimal long3;
        private Decimal long4;
        public ZoneViewModel() { }

        public ZoneViewModel(int id, string nom, Decimal lat1, Decimal lat2, Decimal lat3, Decimal lat4, Decimal long1, Decimal long2, Decimal long3, Decimal long4)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            this.idZonePrelevement = id;
            this.nomZonePrelevement = nom;
            this.lat1 = lat1;
            this.lat2 = lat2;
            this.lat3 = lat3;
            this.lat4 = lat4;
            this.long1 = long1;
            this.long2 = long2;
            this.long3 = long3;
            this.long4 = long4;
        }

        public int idZonePrelevementProperty
        {
            get { return idZonePrelevement; }
        }
        public string nomZonePrelevementProperty
        {
            get { return nomZonePrelevement; }
            set
            {
                this.nomZonePrelevement = value;
                OnPropertyChanged("nomZonePrelevementProperty");
            }
        }
        public Decimal lat1Property
        {
            get { return lat1; }
            set
            {
                this.lat1 = value;
                OnPropertyChanged("lat1Property");
            }
        }
        public Decimal lat2Property
        {
            get { return lat2; }
            set
            {
                this.lat2 = value;
                OnPropertyChanged("lat2Property");
            }
        }
        public Decimal lat3Property
        {
            get { return lat3; }
            set
            {
                this.lat3 = value;
                OnPropertyChanged("lat3Property");
            }
        }
        public Decimal lat4Property
        {
            get { return lat4; }
            set
            {
                this.lat4 = value;
                OnPropertyChanged("lat4Property");
            }
        }
        public Decimal long1Property
        {
            get { return long1; }
            set
            {
                this.long1 = value;
                OnPropertyChanged("long1Property");
            }
        }
        public Decimal long2Property
        {
            get { return long2; }
            set
            {
                this.long2 = value;
                OnPropertyChanged("long2Property");
            }
        }
        public Decimal long3Property
        {
            get { return long3; }
            set
            {
                this.long3 = value;
                OnPropertyChanged("long3Property");
            }
        }
        public Decimal long4Property
        {
            get { return long4; }
            set
            {
                this.long4 = value;
                OnPropertyChanged("long4Property");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                ZoneORM.updateZone(this);
            }
        }

    }
}
