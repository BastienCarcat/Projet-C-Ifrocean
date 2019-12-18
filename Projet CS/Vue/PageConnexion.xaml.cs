using Projet_CS.DAL;
using Projet_CS.ORM;
using Projet_CS.VM;
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
    /// Logique d'interaction pour PageConnexion.xaml
    /// </summary>
    public partial class PageConnexion : Page        
    {
        UtilisateurViewModel myDataObject;
        UtilisateurDAL u = new UtilisateurDAL();
        public PageConnexion()
        {
            InitializeComponent();
        }

        public void connexionButton(object sender, RoutedEventArgs e)
        {
            Window pageConnexion = Window.GetWindow(this);
            myDataObject = UtilisateurORM.getUtilisateur(loginTextBox.Text);

            if(loginTextBox.Text == myDataObject.loginUtilisateurProperty && UtilisateurDAL.hash(passwordTextBox.Text) == myDataObject.passwordUtilisateurProperty)
            {
                if(myDataObject.isAdminUtilisateurProperty == 1)
                {
                    pageConnexion.Content = new MenuDeSelectionAdmin();
                }
                else if(myDataObject.isAdminUtilisateurProperty == 0)
                {
                    pageConnexion.Content = new AfficerChoixEquipe();                    
                }
            }
            else
            {
                pageConnexion.Content = new PageErreurConnexion();
            }


            
        }

    }
}
