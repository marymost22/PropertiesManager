//need to adjust constructor to restaurant object

using System;
using AbstractProperty;
using Rstrnt;

namespace Htl
{
    class Hotel : Property
    {
        

        private Restaurant restaurant;
        private short nrRooms;
        private bool cafeteria;
        private bool _restaurant = false;


        public Hotel() : base()
        {

        }

        public Hotel (string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short nr, Existence cf, Restaurant R) : base( nam, val, ar, loc, we, le, ge, inc, outc)
        {
            restaurant = R;
            nrRooms = nr;

            if (cf == Existence.yes)
            {
                cafeteria = true;
            }
            else
            {
                cafeteria = false;
            }

            _restaurant = true;
        }

        

        //constructor without restaurant
        public Hotel(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short nr, Existence cf) : base( nam, val, ar, loc, we, le, ge, inc, outc)
        {
            
            nrRooms = nr;

            if (cf == Existence.yes)
            {
                cafeteria = true;
            }
            else
            {
                cafeteria = false;
            }
        }

        ~Hotel() {}

        public override void Status()
        {
            Console.WriteLine(" Hotel \n Name: {12} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of rooms: {11} ", this.idProperty, this.value, this.area, this.location, this.waterExpenses, this.lightExpenses, this.gasExpenses, this.incomes, this.outcomes, this.totalIncome, this.totalOutcome, this.nrRooms, this.name);

            if (this.cafeteria == true)
            {
                Console.WriteLine(" Cafeteria: yes");
            }

            if (this.cafeteria == false)
            {
                Console.WriteLine(" Cafeteria: no");
            }

            if(this._restaurant == true)
            {
                Console.WriteLine(" Restaurant: yes");
            }

            if(this._restaurant == false)
            {
                Console.WriteLine(" Restaurant: no");
            }

            


        }
    }
}
