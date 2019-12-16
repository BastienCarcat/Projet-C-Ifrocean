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
    /// Logique d'interaction pour PageErreurConnexion.xaml
    /// </summary>
    public partial class PageErreurConnexion : Page
    {
        public PageErreurConnexion()
        {
            InitializeComponent();
        }

        public void retourButton(object sender, RoutedEventArgs e)
        {
            Window pageConnexion = Window.GetWindow(this);
            pageConnexion.Content = new PageConnexion();
        }
    }
}
