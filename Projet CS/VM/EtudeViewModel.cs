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
    public class EtudeViewModel : INotifyPropertyChanged
    {
        public int idEtude;
        public DateTime date;
        public string titre;
        public int nbTotalEspeceRencontree;
        public int idEquipe;

        public EtudeViewModel() { }

        public EtudeViewModel(int idEtude, DateTime date, string titre, int nbTotalEspeceRencontree, int idEquipe)
        {
            this.idEtude = idEtude;
            this.date = date;
            this.titre = titre;
            this.nbTotalEspeceRencontree = nbTotalEspeceRencontree;
            this.idEquipe = idEquipe;
        }

        public int idEtudeProperty
        {
            get { return idEtude; }
        }
        public string titreEtudeProperty
        {
            get { return titre; }
            set
            {
                this.titre = value;
                OnPropertyChanged("titreEtudeProperty");
            }
        }
        public DateTime dateEtudeProperty
        {
            get { return date; }
            set
            {
                this.date = value;
                OnPropertyChanged("dateEtudeProperty");
            }
        }
        public int nbTotalEspeceRencontreeEtudeProperty
        {
            get { return nbTotalEspeceRencontree; }
            set
            {
                this.nbTotalEspeceRencontree = value;
                OnPropertyChanged("nbTotalEspeceRencontreeEtudeProperty");
            }
        }
        public int idEquipeEtudeProperty
        {
            get { return idEquipe; }
            set
            {
                this.idEquipe = value;
                OnPropertyChanged("idEquipeEtudeProperty");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                EtudeDAO.updateEtude(this);
            }
        }

    }
}
