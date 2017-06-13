using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesManager.Classes
{
    class Administrator : User
    {
        public Administrator(string idUser, string password, string name, string contactNumber, string mail) : base(idUser, password, name, contactNumber, mail)
        {
        }
    }
}
