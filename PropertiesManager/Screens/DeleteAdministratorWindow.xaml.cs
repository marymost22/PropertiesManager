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
using System.Windows.Shapes;

namespace PropertiesManager.Screens
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            foreach (User user in DummyClass.Users)
            {
                cbUsers.Items.Add(user.Name);
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            string strToDelete = (String)cbUsers.SelectedValue;

            if (!DummyClass.DeleteUser(DummyClass.GetUserByName(strToDelete)))
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
