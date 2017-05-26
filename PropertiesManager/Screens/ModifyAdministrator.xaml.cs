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
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class ModifyAdministrator : Page
    {

        //TODO: Add Administrator and user class
        public ModifyAdministrator()
        {
            InitializeComponent();
        }

        private void btModify_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;
            string surname = tbSurname.Text;
            int id = Convert.ToInt32( tbID.Text);
            string pass = tbPassword.Text;
            string email = tbEmail.Text;
            string contact = tbContactNumber.Text; //TODO: Maybe change this

            //TODO: when the user class created, modify here.
        }
    }
}
