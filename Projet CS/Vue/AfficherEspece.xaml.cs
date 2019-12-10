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
    /// Logique d'interaction pour AfficherEspece.xaml
    /// </summary>
    public partial class AfficherEspece : Page
    {
        int selectedEspeceId;
        EspeceViewModel myDataObject;
        EspeceDAL c = new EspeceDAL();
        ObservableCollection<EspeceViewModel> le;
        int compteur = 0;
        public AfficherEspece()
        {
            InitializeComponent();
            le = EspeceORM.listeEspeces();
            listeEspeces.ItemsSource = le;
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {
            myDataObject = new EspeceViewModel();
            myDataObject.nomEspeceProperty = nomTextBox.Text;            
            EspeceViewModel nouveau = new EspeceViewModel(EspeceDAL.getMaxIdEspece() + 1, myDataObject.nomEspeceProperty);
            le.Add(nouveau);
            EspeceDAO.insertEspece(nouveau);
            listeEspeces.Items.Refresh();
            compteur = le.Count();
            myDataObject = new EspeceViewModel(EspeceDAL.getMaxIdEspece() + 1, "");
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            EspeceViewModel toRemove = (EspeceViewModel)listeEspeces.SelectedItem;
            le.Remove(toRemove);
            listeEspeces.Items.Refresh();
            EspeceDAO.supprimerEspece(selectedEspeceId);
        }

        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelection();
        }
        private void listeEspeces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeEspeces.SelectedIndex < le.Count) && (listeEspeces.SelectedIndex >= 0))
            {
                selectedEspeceId = (le.ElementAt<EspeceViewModel>(listeEspeces.SelectedIndex)).idEspeceProperty;
            }
        }
    }
}
