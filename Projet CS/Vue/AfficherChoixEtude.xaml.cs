﻿using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour AfficherChoixEtude.xaml
    /// </summary>
    public partial class AfficherChoixEtude : Page
    {
        EtudeDAL e = new EtudeDAL();
        ObservableCollection<EtudeViewModel> le;
        public AfficherChoixEtude()
        {
            InitializeComponent();
            le = EtudeORM.listeEtudes();
            etudeComboBox.ItemsSource = le;
        }
        public void pageSuivante(object sender, RoutedEventArgs e)
        {
            Window page = Window.GetWindow(this);
            page.Content = new AfficherChoixEtude();
        }
    }
}
