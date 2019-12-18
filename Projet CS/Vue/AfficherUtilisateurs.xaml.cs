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
        UtilisateurViewModel myDataObjectUtilisateur;
        UtilisateurDAL c = new UtilisateurDAL();
        UtilisateurHasEquipeDAL ue = new UtilisateurHasEquipeDAL();
        ObservableCollection<UtilisateurViewModel> lp;        
        ObservableCollection<UtilisateurHasEquipeViewModel> lue;        
        public AfficherUtilisateurs()
        {
            InitializeComponent();
            lp = UtilisateurORM.listeUtilisateurs();
            lue = UtilisateurHasEquipeORM.listeUtilisateurHasEquipes();
            listeUtilisateurs.ItemsSource = lp;
            listeUtilisateursHasEquipe.ItemsSource = lue;
            //EquipeComboBoxColumn.ItemsSource = lue;
            myDataObjectUtilisateur = new UtilisateurViewModel();
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {
            

            myDataObjectUtilisateur.nomUtilisateurProperty = nomTextBox.Text;

            myDataObjectUtilisateur.prenomUtilisateurProperty = prenomTextBox.Text;

            myDataObjectUtilisateur.loginUtilisateurProperty = loginTextBox.Text;

            myDataObjectUtilisateur.passwordUtilisateurProperty = passwordTextBox.Text;

            if (adminCheckBox.IsChecked ?? false)
            {
                 myDataObjectUtilisateur.isAdminUtilisateurProperty = 1;
            }
            else
            {
                myDataObjectUtilisateur.isAdminUtilisateurProperty = 0;
            }



            UtilisateurViewModel nouveau = new UtilisateurViewModel(UtilisateurDAL.getMaxIdUtilisateur() + 1, myDataObjectUtilisateur.nomUtilisateurProperty, myDataObjectUtilisateur.prenomUtilisateurProperty, myDataObjectUtilisateur.isAdminUtilisateurProperty, myDataObjectUtilisateur.passwordUtilisateurProperty, myDataObjectUtilisateur.loginUtilisateurProperty);
            lp.Add(nouveau);
            UtilisateurDAO.insertUtilisateur(nouveau);
            listeUtilisateurs.Items.Refresh();            
            myDataObjectUtilisateur = new UtilisateurViewModel(UtilisateurDAL.getMaxIdUtilisateur() + 1, "", "", myDataObjectUtilisateur.isAdminUtilisateurProperty, "", "");
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            UtilisateurViewModel toRemove = (UtilisateurViewModel)listeUtilisateurs.SelectedItem;
            lp.Remove(toRemove);
            listeUtilisateurs.Items.Refresh();
            UtilisateurDAO.supprimerUtilisateur(selectedUtilisateurId);
        }
        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelectionAdmin();
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
