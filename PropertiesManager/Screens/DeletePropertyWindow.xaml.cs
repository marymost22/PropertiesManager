using AbstractProperty;
using Artificial_database;
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
using System.Windows.Shapes;

namespace PropertiesManager.Screens
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            foreach (Property property in DummyClass.Properties)
            {
                cbProperties.Items.Add(property.Name);
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            string strToDelete = (String)cbProperties.SelectedValue;
            
            if (!DummyClass.DeleteProperty(DummyClass.GetPropertyByName(strToDelete)))
            {
                //TODO: Put red label showing the error
            }
            else
            {
                this.Close();
            }
        }
    }
}
