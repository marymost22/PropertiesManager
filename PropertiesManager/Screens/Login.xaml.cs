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
using Artificial_database;
using PropertiesManager.Classes;

namespace PropertiesManager.Screens
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            AppController.CurrentUser = null;
        }


        private void btAccept_Click(object sender, RoutedEventArgs e)
        {
            string userID = tbUserID.Text;
            string password = tbPassword.Password;

            User u = DummyClass.userExist(userID, password);
            if (u != null)
            { 
                if (u.Password == password)
                {
                    AppController.CurrentUser = u;
                    //We show the Main page, where the properties are shown
                     MainPageProperties page = new MainPageProperties(); 
                    NavigationService.Navigate(page);
                }
                else
                {
                    labelError.Text = "Wrong password. Please, try again";
                    labelError.Visibility = Visibility.Visible;
                }
            }
            else
            {
                labelError.Text = "Invalid user. Please, try again";
                labelError.Visibility = Visibility.Visible;
            }
        }
    }
}
