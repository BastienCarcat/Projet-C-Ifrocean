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
    /// Logique d'interaction pour AfficherDepartement.xaml
    /// </summary>
    public partial class AfficherDepartement : Page
    {
        int selectedDepartementId;
        DepartementViewModel myDataObject;
        DepartementDAL c = new DepartementDAL();
        ObservableCollection<DepartementViewModel> le;        
        public AfficherDepartement()
        {
            InitializeComponent();
            le = DepartementORM.listeDepartements();
            listeDepartements.ItemsSource = le;
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {
            myDataObject = new DepartementViewModel();
            myDataObject.nomDepartementProperty = nomTextBox.Text;
            DepartementViewModel nouveau = new DepartementViewModel(DepartementDAL.getMaxIdDepartement() + 1, myDataObject.nomDepartementProperty);
            le.Add(nouveau);
            DepartementDAO.insertDepartement(nouveau);
            listeDepartements.Items.Refresh();            
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            DepartementViewModel toRemove = (DepartementViewModel)listeDepartements.SelectedItem;
            le.Remove(toRemove);
            listeDepartements.Items.Refresh();
            DepartementDAO.supprimerDepartement(selectedDepartementId);
        }
        private void listeDepartements_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeDepartements.SelectedIndex < le.Count) && (listeDepartements.SelectedIndex >= 0))
            {
                selectedDepartementId = (le.ElementAt<DepartementViewModel>(listeDepartements.SelectedIndex)).idDepartementProperty;
            }
        }
        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelection();
        }
        private void PrenomTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
