using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesManager.Classes
{
    abstract class User
    {
        private string idUser;
        private string password;
        private string name;
        private string contactNumber;
        private string mail;
        
        public User (string idUser, string password, string name, string contactNumber, string mail)
        {
            this.IdUser = idUser;
            this.Password = password;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.Mail = mail;
        }

        public string IdUser { get => idUser; set => idUser = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        
        public string Mail { get => mail; set => mail = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }


        public override bool Equals(object obj)
        {
            var item = obj as User;

            if (item == null)
            {
                return false;
            }

            return this.idUser.Equals(item.idUser);
        }

        public override int GetHashCode()
        {
            return this.idUser.GetHashCode();
        }
    }

}
