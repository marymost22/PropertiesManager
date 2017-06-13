
using Aprtmnt;
using Artificial_database;
using Flt;
using Frm;
using Hs;
using Htl;
using Rstrnt;
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
    /// Lógica de interacción para AddProperty.xaml
    /// </summary>
    public partial class AddProperty : Page
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string newName = tbName.Text;
            string newLocation = tbLocation.Text;
            double area = Convert.ToDouble(tbArea.Text);

            int selectedType = cbType.SelectedIndex;

            if (newName != null && newLocation != null && area != 0 && selectedType >= 0)
            {
                switch (selectedType)
                {
                    case 0: //Apartment
                        DummyClass.AddProperty(new Apartment(newName, newLocation, area));
                        break;
                    case 1: //Farm
                        DummyClass.AddProperty(new Farm(newName, newLocation, area));
                        break;

                    case 2: //Flat
                        DummyClass.AddProperty(new Flat(newName, newLocation, area));
                        break;
                    case 3: //Hotel
                        DummyClass.AddProperty(new Hotel(newName, newLocation, area));
                        break;
                    case 4: //House
                        DummyClass.AddProperty(new House(newName, newLocation, area));
                        break;
                    case 5: //Restaurant
                        DummyClass.AddProperty(new Restaurant(newName, newLocation, area));
                        break;
                }
                NavigationService.GoBack();
            }
            else
            {
                //TODO: SHOW ERROR LABEL HERE!
            }
        }
    }
}
