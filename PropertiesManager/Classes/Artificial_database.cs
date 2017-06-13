using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractProperty;
using Hs;
using Frm;
using Aprtmnt;
using Rstrnt;
using Htl;
using Flt;
using PropertiesManager.Classes;

namespace Artificial_database
{
    static class DummyClass //static means that you do not create any instances of the class on your own.

    {
        static private Restaurant Gessler = new Restaurant("Gessler", 5000, 500, "Nowomiejska, Warszawa", 200, 300, 200, 1200, 700);
        static private Hotel Hilton = new Hotel("Hilton", 9000, 250, "Drewnowska 36, Lodz", 500, 700, 250, 5000, 2323, 15, Gessler, true);
        static private Apartment Penthouse = new Apartment("Penthouse", 1500000, 300, "Mostowa 42, Poznan", 400, 400, 400, 1600, 1350, 1, 3, 1, true, true);
        static private Farm McDonald = new Farm("McDonald", 30000, 1500, "Hektarowa 4, Nieznajdowy Duze", 650, 300, 250, 3500, 1410);
        static private House Gregory = new House("Gregory", 1600485, 150, "Baker Street, London", 300, 300, 300, 0, 1000);
        static private Flat Ataner = new Flat("Ataner", 20000000, 5000, "Marcelinska 96, Poznan", 2000, 2300, 1337, 25000, 12500, 22, 45, 5, true);


        static public List<Property> Properties = new List<Property>() { Gessler, Hilton, Penthouse, McDonald, Gregory, Ataner };


        static public List<Property> SearchProperty (string name, string valueStr, string location)
        {
            double value = Convert.ToDouble(valueStr);
            List<Property> findProps = new List<Property>();

           foreach( Property prop in Properties)
            {
                if ( name!=null && prop.Name.Contains(name) && !findProps.Contains(prop)) findProps.Add(prop);
                if (valueStr!=null && prop.Value== value && !findProps.Contains(prop)) findProps.Add(prop);
                if (location !=null && prop.Location.Contains(location) && !findProps.Contains(prop)) findProps.Add(prop);
            }
           
            return findProps;
        }

        static public Property GetPropertyByName(string Name)
        {
            Property toFind = Properties.Find(prop => prop.Name.Equals(Name));
            return toFind;
        }

        static public void AddProperty(Property prop)
        {
            Properties.Add(prop);
        }

        

        static public bool DeleteProperty(Property prop)
        {
            Property toDelete = Properties.Find(property => property.IdProperty == prop.IdProperty);
            return (Properties.Remove(toDelete));
        }

        static public void ModifyProperty(Property prop)
        {
            DeleteProperty(prop);
            AddProperty(prop);
        }

        static int userId = 0;
        
        static Administrator admin1 = new Administrator("Admin1", "1234", "User1" + userId, "555123456", "userMail@mail.com");
        static Administrator admin2 = new Administrator("Admin2", "1234", "User2" + userId, "555123456", "userMail@mail.com");
        static Administrator admin3 = new Administrator("Admin3", "1234", "User3" + userId, "555123456", "userMail@mail.com");
        static Administrator admin4 = new Administrator("Admin4", "1234", "User4" + userId, "555123456", "userMail@mail.com");

        static Owner owner1 = new Owner("Owner1", "1234", "User5" + userId, "555123456", "userMail@mail.com");
        static Owner owner2 = new Owner("Owner2", "1234", "User6" + userId, "555123456", "userMail@mail.com");

        static public List<User> Users = new List<User>() { admin1, admin2, admin3, admin4, owner1, owner2 };


        static public User userExist(string userId, string password)
        {
            User toFind = Users.Find(user => user.IdUser.Equals(userId));
            return toFind;
        }

        static public void AddUser(User u)
        {
            Users.Add(u);
        }

        static public bool DeleteUser(User user)
        {
            User toDelete = Users.Find(u => u.IdUser == user.IdUser);
            return (Users.Remove(toDelete));
        }

        static public User GetUserByName(string Name)
        {
            User toFind = Users.Find(u => u.Name.Equals(Name));
            return toFind;
        }


        static public List<User> SearchUser(string name, string typeStr)
        {
            List<User> findUsers = new List<User>();

            foreach (User u in Users)
            {
                if (name!=null && u.Name.Contains(name) && !findUsers.Contains(u)) findUsers.Add(u);


                switch (typeStr)
                {
                    case "Administrator":
                        if (u is Administrator && !findUsers.Contains(u)) findUsers.Add(u);
                        break;
                    case "Owner":
                        if (u is Owner && !findUsers.Contains(u)) findUsers.Add(u);
                        break;
                }
            }
            return findUsers;
        }
    }
}


