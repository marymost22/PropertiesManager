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
    /// Lógica de interacción para Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {


        public Page2()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string newName = tbName.Text;
            string newSurname = tbSurname.Text;
            string newId = tbID.Text;
            string newPassword = tbPassword.Text;
            string newContactNumber = tbContactNumber.Text;
            string newEmail = tbEmail.Text;

            int selectedType = cbType.SelectedIndex;

            if (newName != null && newSurname != null && newId != null && newPassword!=null && newContactNumber !=null && newEmail!=null && selectedType >= 0)
            {
                switch (selectedType)
                {
                    case 0: //Administrator
                        DummyClass.AddUser(new Administrator(newId,newPassword, newName + newSurname, newContactNumber, newEmail));
                        break;
                    case 1: //Owner
                        DummyClass.AddUser(new Owner(newId, newPassword, newName + newSurname, newContactNumber, newEmail));
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



