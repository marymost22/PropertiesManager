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

namespace PropertiesManager.Screens
{
    /// <summary>
    /// Lógica de interacción para MainPageUsers.xaml
    /// </summary>
    public partial class MainPageUsers : Page
    {
        public MainPageUsers()
        {
            InitializeComponent();
        }

        private void btnViewUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2()); //This is AddAdministrator page
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Window2 deleteUserWindow = new Window2();
            deleteUserWindow.Show();
        }
    }
}
