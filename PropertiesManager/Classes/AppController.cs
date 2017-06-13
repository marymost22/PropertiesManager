using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesManager.Classes
{
    static class AppController
    {
        private static User currentUser;

        internal static User CurrentUser { get => currentUser; set => currentUser = value; }
    }
}
