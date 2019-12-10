using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Projet_CS.VM;
using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.DAO;


namespace Projet_CS.Vue
{
    /// <summary>
    /// Logique d'interaction pour AfficherEtude.xaml
    /// </summary>
    public partial class AfficherEtude : Page
    {
        int selectedEtudeId;
        EtudeViewModel myDataObject;
        EtudeDAL c = new EtudeDAL();
        ObservableCollection<EtudeViewModel> lp;
        int compteur = 0;
        public AfficherEtude()
        {
            InitializeComponent();
            lp = EtudeORM.listeEtudes();
            listeEtudes.ItemsSource = lp;
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {

            myDataObject = new EtudeViewModel();

            DateTime defaultValDate = DateTime.Now;
            myDataObject.dateEtudeProperty = DateTime.TryParse(dateTextBox.Text, out DateTime resultDate) ? resultDate : defaultValDate;

            myDataObject.titreEtudeProperty = titreTextBox.Text;

            int.TryParse(nbTotalEspeceRencontreeTextBox.Text, out int resultNbEspece);
            myDataObject.nbTotalEspeceRencontreeEtudeProperty = resultNbEspece;

            int defaultValEquipe = 1; //si mauvaise valeur -> équipe 1 par default
            myDataObject.equipeEtude = EquipeORM.getEquipe(int.TryParse(idEquipeTextBox.Text, out int resultEquipe) ? resultEquipe : defaultValEquipe);

            EtudeViewModel nouveau = new EtudeViewModel(EtudeDAL.getMaxIdEtude() + 1, myDataObject.dateEtudeProperty, myDataObject.titreEtudeProperty, myDataObject.nbTotalEspeceRencontreeEtudeProperty, myDataObject.equipeEtudeProperty);
            lp.Add(nouveau);
            EtudeDAO.insertEtude(nouveau);
            listeEtudes.Items.Refresh();
            compteur = lp.Count();
            myDataObject = new EtudeViewModel(EtudeDAL.getMaxIdEtude() + 1, myDataObject.dateEtudeProperty, "", myDataObject.nbTotalEspeceRencontreeEtudeProperty, myDataObject.equipeEtudeProperty);
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            EtudeViewModel toRemove = (EtudeViewModel)listeEtudes.SelectedItem;
            lp.Remove(toRemove);
            listeEtudes.Items.Refresh();
            EtudeDAO.supprimerEtude(selectedEtudeId);
        }

        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelection();
        }
        private void listeEtudes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeEtudes.SelectedIndex < lp.Count) && (listeEtudes.SelectedIndex >= 0))
            {
                selectedEtudeId = (lp.ElementAt<EtudeViewModel>(listeEtudes.SelectedIndex)).idEtudeProperty;
            }
        }
    }
}
