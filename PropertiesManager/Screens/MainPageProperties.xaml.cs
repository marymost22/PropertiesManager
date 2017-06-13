using AbstractProperty;
using Artificial_database;
using PropertiesManager.Classes;
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
    /// Lógica de interacción para MainPageProperties.xaml
    /// </summary>
    public partial class MainPageProperties : Page
    {
        public MainPageProperties()
        {
            InitializeComponent();
            List<Property> properties = DummyClass.Properties;
          //  lvProperties.ItemsSource = properties;
            linkListItems(properties);
            if (AppController.CurrentUser is Administrator)
            {
                btnAdd.Visibility = (Visibility.Hidden);
                btnDelete.Visibility = Visibility.Hidden;
            }
        }

        private void btnViewUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPageUsers());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string nameSrch;
            string locationSrch;
            string valueSrch;

            nameSrch = tbName.Text == "Name" ? null : tbName.Text;
            locationSrch = tbLocation.Text == "Location" ? null : tbLocation.Text;
            valueSrch = tbValue.Text == "Value" ? null : tbValue.Text;

            lvProperties.ItemsSource = DummyClass.SearchProperty(nameSrch, locationSrch, valueSrch);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProperty());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Window1 deleteWindow = new Window1();
            deleteWindow.Show();
        }


        private void linkListItems(List<Property> items)
        {
            lvProperties.Items.Clear();
            foreach (Property item in items)
            {
                lvProperties.Items.Add(item);
            }
        }
    }
}
