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
    /// Logique d'interaction pour AfficherZone.xaml
    /// </summary>
    public partial class AfficherZone : Page
    {
        int selectedZoneId;
        ZoneViewModel myDataObject;
        ZoneDAL c = new ZoneDAL();
        ObservableCollection<ZoneViewModel> lp;       
        public AfficherZone()
        {
            InitializeComponent();
            lp = ZoneORM.listeZones();
            listeZones.ItemsSource = lp;
            myDataObject = new ZoneViewModel();
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {

            myDataObject.nomZonePrelevementProperty = nomTextBox.Text;
            Decimal defaultValue = 0.0M; //si la string est abhérente, les lat et long par défaut sont de 0,0
            Decimal result;
            myDataObject.lat1Property = Decimal.TryParse(lat1TextBox.Text, out result) ? result : defaultValue;
            myDataObject.long1Property = Decimal.TryParse(long1TextBox.Text, out result) ? result : defaultValue;
            myDataObject.lat2Property = Decimal.TryParse(lat2TextBox.Text, out result) ? result : defaultValue;
            myDataObject.long2Property = Decimal.TryParse(long2TextBox.Text, out result) ? result : defaultValue;
            myDataObject.lat3Property = Decimal.TryParse(lat3TextBox.Text, out result) ? result : defaultValue;
            myDataObject.long3Property = Decimal.TryParse(long3TextBox.Text, out result) ? result : defaultValue;            
            myDataObject.lat4Property = Decimal.TryParse(lat4TextBox.Text, out result) ? result : defaultValue;            
            myDataObject.long4Property = Decimal.TryParse(long4TextBox.Text, out result) ? result : defaultValue;

            ZoneViewModel nouveau = new ZoneViewModel(ZoneDAL.getMaxIdZone() + 1, myDataObject.nomZonePrelevementProperty, myDataObject.lat1Property, myDataObject.lat2Property, myDataObject.lat3Property, myDataObject.lat4Property, myDataObject.long1Property, myDataObject.long2Property, myDataObject.long3Property, myDataObject.long4Property);
            lp.Add(nouveau);
            ZoneDAO.insertZone(nouveau);
            listeZones.Items.Refresh();
            
            //myDataObject = new ZoneViewModel(ZoneDAL.getMaxIdZone() + 1, "", "", myDataObject.isAdminZoneProperty, "", "");
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            ZoneViewModel toRemove = (ZoneViewModel)listeZones.SelectedItem;
            lp.Remove(toRemove);
            listeZones.Items.Refresh();
            ZoneDAO.supprimerZone(selectedZoneId);
        }
        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelectionAdmin();
        }
        private void listeZones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeZones.SelectedIndex < lp.Count) && (listeZones.SelectedIndex >= 0))
            {
                selectedZoneId = (lp.ElementAt<ZoneViewModel>(listeZones.SelectedIndex)).idZonePrelevementProperty;
            }
        }
    }
}
