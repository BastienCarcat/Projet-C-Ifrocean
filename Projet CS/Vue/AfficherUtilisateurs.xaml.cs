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
    /// Logique d'interaction pour AfficherUtilisateurs.xaml
    /// </summary>
    public partial class AfficherUtilisateurs : Page
    {
        int selectedUtilisateurId;
        UtilisateurViewModel myDataObject;
        UtilisateurDAL c = new UtilisateurDAL();
        ObservableCollection<UtilisateurViewModel> lp;
        int compteur = 0;
        public AfficherUtilisateurs()
        {
            InitializeComponent();
            lp = UtilisateurORM.listeUtilisateurs();
            listeUtilisateurs.ItemsSource = lp;
        }
        private void nomPrenomButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UtilisateurViewModel nouveau = new UtilisateurViewModel(UtilisateurDAL.getMaxIdUtilisateur() + 1, myDataObject.nomUtilisateurProperty, myDataObject.prenomUtilisateurProperty, myDataObject.isAdminUtilisateurProperty, myDataObject.passwordUtilisateurProperty, myDataObject.loginUtilisateurProperty);
            lp.Add(nouveau);
            UtilisateurDAO.insertUtilisateur(nouveau);
            listeUtilisateurs.Items.Refresh();
            compteur = lp.Count();
            myDataObject = new UtilisateurViewModel(UtilisateurDAL.getMaxIdUtilisateur() + 1, "", "", myDataObject.isAdminUtilisateurProperty, "", "");
        }
        private void supprimerButton_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UtilisateurViewModel toRemove = (UtilisateurViewModel)listeUtilisateurs.SelectedItem;
            lp.Remove(toRemove);
            listeUtilisateurs.Items.Refresh();
            UtilisateurDAO.supprimerUtilisateur(selectedUtilisateurId);
        }
        private void listeUtilisateurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeUtilisateurs.SelectedIndex < lp.Count) && (listeUtilisateurs.SelectedIndex >= 0))
            {
                selectedUtilisateurId = (lp.ElementAt<UtilisateurViewModel>(listeUtilisateurs.SelectedIndex)).idUtilisateurProperty;
            }
        }
    }
}
