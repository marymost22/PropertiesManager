using System;




namespace AbstractProperty
{


    abstract class Property
    {

        static int instances;

        private string name; //name of property
        private int idProperty = 0; //number for identification
        private double value; //value in hypothetical currency 
        private double area; //physical area measured in square meters
        private string location; //address of given property
        private double waterExpenses; //monthly outcome regarding water expenses
        private double lightExpenses; //monthly outcome regarding light expenses
        private double gasExpenses; //monthly outcome regarding gas expenses
        private double incomes; //general monthly income
        private double outcomes; //general monthly outcome
        private double totalIncome; // total income counted since creating property object in program 
        private double totalOutcome; //total outcome counter since creating property object in program

        public string Name { get => name; set => name = value; }
        public int IdProperty { get => idProperty; set => idProperty = value; }
        public double Value { get => value; set => this.value = value; }
        public double Area { get => area; set => area = value; }
        public string Location { get => location; set => location = value; }
        public double WaterExpenses { get => waterExpenses; set => waterExpenses = value; }
        public double LightExpenses { get => lightExpenses; set => lightExpenses = value; }
        public double GasExpenses { get => gasExpenses; set => gasExpenses = value; }
        public double Incomes { get => incomes; set => incomes = value; }
        public double Outcomes { get => outcomes; set => outcomes = value; }
        public double TotalIncome { get => totalIncome; set => totalIncome = value; }
        public double TotalOutcome { get => totalOutcome; set => totalOutcome = value; }

        public Property (string name, string location, double area)
        {
            this.Name = name;
            this.Location = location;
            this.Area = area;
        }

        public Property(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc)
        {
            this.Name = nam;
            this.IdProperty = ++instances;
            this.Value = val;
            this.Area = ar;
            this.Location = loc;
            this.WaterExpenses = we;
            this.LightExpenses = le;
            this.GasExpenses = ge;
            this.Incomes = inc;
            this.Outcomes = outc;
            this.TotalIncome = inc;
            this.TotalOutcome = outc;
        }



        public abstract void Status(); //overloaded function showing status of property
        




        public bool ModifyProperty(string name, string location, double area) //Edits existing information about property, overwrites data in database.
        {
            if (name != null & location != null & Value != 0)
            { 
                this.Name = name;
                this.Location = location;
                this.Area = area;
                Artificial_database.DummyClass.ModifyProperty(this);
                return true;
            }
            return false;
        }


        public override bool Equals(object obj)
        {
            var item = obj as Property;

            if (item == null)
            {
                return false;
            }

            return this.IdProperty.Equals(item.IdProperty);
        }

        public override int GetHashCode()
        {
            return this.idProperty.GetHashCode();
        }
    }

}

    
        
        
        









