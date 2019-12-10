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
    /// Logique d'interaction pour AfficherEquipe.xaml
    /// </summary>
    public partial class AfficherEquipe : Page
    {
        int selectedEquipeId;
        EquipeViewModel myDataObject;
        EquipeDAL c = new EquipeDAL();
        ObservableCollection<EquipeViewModel> le;
       
        public AfficherEquipe()
        {
            InitializeComponent();
            le = EquipeORM.listeEquipes();
            listeEquipes.ItemsSource = le;
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {            
            myDataObject = new EquipeViewModel();
            myDataObject.nomEquipeProperty = nomTextBox.Text;
            int.TryParse(nombreMembresTextBox.Text, out int result);
            myDataObject.nombreMembresEquipeProperty = result;
            EquipeViewModel nouveau = new EquipeViewModel(EquipeDAL.getMaxIdEquipe() + 1, myDataObject.nomEquipeProperty, myDataObject.nombreMembresEquipeProperty);
            le.Add(nouveau);
            EquipeDAO.insertEquipe(nouveau);
            listeEquipes.Items.Refresh();            
        }

        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            EquipeViewModel toRemove = (EquipeViewModel)listeEquipes.SelectedItem;
            le.Remove(toRemove);
            listeEquipes.Items.Refresh();
            EquipeDAO.supprimerEquipe(selectedEquipeId);
        }
        private void listeEquipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeEquipes.SelectedIndex < le.Count) && (listeEquipes.SelectedIndex >= 0))
            {
                selectedEquipeId = (le.ElementAt<EquipeViewModel>(listeEquipes.SelectedIndex)).idEquipeProperty;
            }
        }
    }
}
