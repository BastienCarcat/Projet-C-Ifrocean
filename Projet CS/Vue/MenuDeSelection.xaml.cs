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

namespace Projet_CS.Vue
{
    /// <summary>
    /// Logique d'interaction pour MenuDeSelection.xaml
    /// </summary>
    public partial class MenuDeSelection : Page
    {
        public MenuDeSelection()
        {
            InitializeComponent();
        }
        private void ouvrirCommune(object sender, RoutedEventArgs e)
        {
            Window pageCommune = Window.GetWindow(this);
            pageCommune.Content = new AfficherCommune();
        }
        private void ouvrirDepartement(object sender, RoutedEventArgs e)
        {
            Window pageDepartement = Window.GetWindow(this);
            pageDepartement.Content = new AfficherDepartement();
        }
        private void ouvrirEquipe(object sender, RoutedEventArgs e)
        {
            Window pageEquipe = Window.GetWindow(this);
            pageEquipe.Content = new AfficherEquipe();
        }
        private void ouvrirEspece(object sender, RoutedEventArgs e)
        {
            Window pageEspece = Window.GetWindow(this);
            pageEspece.Content = new AfficherEspece();
        }
        private void ouvrirEtude(object sender, RoutedEventArgs e)
        {
            Window pageEtude = Window.GetWindow(this);
            pageEtude.Content = new AfficherEtude();
        }
        private void ouvrirPlage(object sender, RoutedEventArgs e)
        {
            Window pagePlage = Window.GetWindow(this);
            pagePlage.Content = new AfficherPlages();
        }
        private void ouvrirUtilisateur(object sender, RoutedEventArgs e)
        {
            Window pageUtilisateur = Window.GetWindow(this);
            pageUtilisateur.Content = new AfficherUtilisateurs();
        }
    }
}
