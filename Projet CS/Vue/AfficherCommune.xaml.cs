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
    /// Logique d'interaction pour AfficherCommune.xaml
    /// </summary>
    public partial class AfficherCommune : Page
    {
        int selectedCommuneId;
        CommuneViewModel myDataObject;
        CommuneDAL c = new CommuneDAL();
        DepartementDAL d = new DepartementDAL();
        ObservableCollection<CommuneViewModel> le;
        ObservableCollection<DepartementViewModel> ld;
        public AfficherCommune()
        {
            InitializeComponent();
            le = CommuneORM.listeCommunes();
            ld = DepartementORM.listeDepartements();
            listeCommunes.ItemsSource = le;
            idDepartementTextBox.ItemsSource = ld;
            myDataObject = new CommuneViewModel();
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {
            myDataObject.nomCommuneProperty = nomTextBox.Text;

            //int DepartementIdToParse = idDepartementTextBox.SelectedIndex;
            //int defaultValue = 1; //si la string est abhérente, le département par défaut est 1 -> mauvaisNumDépartement
            //int result;
            myDataObject.departementCommune = DepartementORM.getDepartement(idDepartementTextBox.SelectedIndex + 2);
            CommuneViewModel nouveau = new CommuneViewModel(CommuneDAL.getMaxIdCommune() + 1, myDataObject.nomCommuneProperty, myDataObject.departementCommuneProperty);
            le.Add(nouveau);
            CommuneDAO.insertCommune(nouveau);
            listeCommunes.Items.Refresh();                       
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            CommuneViewModel toRemove = (CommuneViewModel)listeCommunes.SelectedItem;
            le.Remove(toRemove);
            listeCommunes.Items.Refresh();
            CommuneDAO.supprimerCommune(selectedCommuneId);
        }
        private void listeCommunes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeCommunes.SelectedIndex < le.Count) && (listeCommunes.SelectedIndex >= 0))
            {
                selectedCommuneId = (le.ElementAt<CommuneViewModel>(listeCommunes.SelectedIndex)).idCommuneProperty;
            }
        }
        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelectionAdmin();
        }

        //private void ComboBoxDepartement()
        //{
             
        //}
    }
}
