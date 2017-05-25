using System;




namespace AbstractProperty
{


    abstract class Property
    {
        public enum Existence
        {
            no,
            yes
        }

        static int instances;

        protected string name; //name of property
        protected int idProperty = 0; //number for identification
        protected double value; //value in hypothetical currency 
        protected double area; //physical area measured in square meters
        protected string location; //address of given property
        protected double waterExpenses; //monthly outcome regarding water expenses
        protected double lightExpenses; //monthly outcome regarding light expenses
        protected double gasExpenses; //monthly outcome regarding gas expenses
        protected double incomes; //general monthly income
        protected double outcomes; //general monthly outcome
        protected double totalIncome; // total income counted since creating property object in program 
        protected double totalOutcome; //total outcome counter since creating property object in program


        protected Property()
        {
            name = "null";
            idProperty = 0;
            value = 0;
            area = 0;
            location = "null";
            waterExpenses = 0;
            lightExpenses = 0;
            gasExpenses = 0;
            incomes = 0;
            outcomes = 0;
            totalIncome = 0;
            totalOutcome = 0;
        }


        protected Property(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc)
        {
            name = nam;
            idProperty = ++instances;
            value = val;
            area = ar;
            location = loc;
            waterExpenses = we;
            lightExpenses = le;
            gasExpenses = ge;
            incomes = inc;
            outcomes = outc;
            totalIncome = inc;
            totalOutcome = outc;
        }


        public int getId()
        {
            return idProperty;
        }

        public abstract void Status(); //overloaded function showing status of property
        

        public string getName()
        {
            return name;
        }
        
        

        public void ModifyProperty() //Edits existing information about property, overwrites data in database.
        {

        }

        public void DeleteProperty() //Removes information containing specified property from database, and not showing it anymore in the GUI.

        {

        }

        public void SearchProperty() //Allows to all the users to search a specific property taking in count some characteristics as : id, area, value, type, owner or administrator

        {

        }
    }

}

    
        
        
        









