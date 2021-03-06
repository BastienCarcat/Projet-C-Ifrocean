﻿using System;
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
    /// Logique d'interaction pour AfficherPlages.xaml
    /// </summary>
    public partial class AfficherPlages : Page
    {
        int selectedPlageId;
        PlageViewModel myDataObject;
        PlageDAL c = new PlageDAL();
        ObservableCollection<PlageViewModel> lp;
        int compteur = 0;
        public AfficherPlages()
        {
            InitializeComponent();
            lp = PlageORM.listePlages();
            listePlages.ItemsSource = lp;
            myDataObject = new PlageViewModel();
        }
        private void ajouterButton(object sender, RoutedEventArgs e)
        {            
            myDataObject.nomPlageProperty = nomTextBox.Text;

            int defaultValueCommune = 1; //si la string est abhérente, le département par défaut est 1 -> mauvaisNumDépartement
            int resultCommune;
            myDataObject.communePlage = CommuneORM.getCommune(int.TryParse(idCommuneTextBox.Text, out resultCommune) ? resultCommune : defaultValueCommune);

            int.TryParse(nbEspecesDifferentesTextBox.Text, out int resultNbEspeces);
            myDataObject.nbEspecesDifferentesPlageProperty = resultNbEspeces;
            
            float resultSurface;
            float defaultValueSurface = 0.0F;
            myDataObject.surfacePlageProperty = float.TryParse(surfaceTextBox.Text, out resultSurface) ? resultSurface : defaultValueSurface;

            PlageViewModel nouveau = new PlageViewModel(PlageDAL.getMaxIdPlage() + 1, myDataObject.nomPlageProperty, myDataObject.communePlage, myDataObject.nbEspecesDifferentesPlageProperty, myDataObject.surfacePlageProperty);
            lp.Add(nouveau);
            PlageORM.insertPlage(nouveau);
            listePlages.Items.Refresh();
            compteur = lp.Count();
            myDataObject = new PlageViewModel(PlageDAL.getMaxIdPlage() + 1, "", myDataObject.communePlage, myDataObject.nbEspecesDifferentesPlageProperty, myDataObject.surfacePlageProperty);
        }
        private void supprimerButton(object sender, RoutedEventArgs e)
        {
            PlageViewModel toRemove = (PlageViewModel)listePlages.SelectedItem;
            lp.Remove(toRemove);
            listePlages.Items.Refresh();
            PlageORM.supprimerPlage(selectedPlageId);
        }
        private void retourMenu(object sender, RoutedEventArgs e)
        {
            Window pageMenu = Window.GetWindow(this);
            pageMenu.Content = new MenuDeSelectionAdmin();
        }
        private void listePlages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listePlages.SelectedIndex < lp.Count) && (listePlages.SelectedIndex >= 0))
            {
                selectedPlageId = (lp.ElementAt<PlageViewModel>(listePlages.SelectedIndex)).idPlageProperty;
            }
        }
    }
}
