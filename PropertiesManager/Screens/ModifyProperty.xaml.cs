using AbstractProperty;
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

namespace PropertiesManager
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private Property property;

        public Page1()
        {
            InitializeComponent();
        }

        private void btModify_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string location = tbLocation.Text;
            double area = Convert.ToDouble(tbArea.Text);

            if (!property.ModifyProperty(name, location, area))
            {
                //TODO: Add a red label to show a message with the error
            }
        }
    }
}
