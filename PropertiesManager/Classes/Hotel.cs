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

        public Hotel(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short numberRestaurants, Restaurant restaurant, bool cafeteria) : base(nam, val, ar, loc, we, le, ge, inc, outc)
        {
            this.Restaurant = restaurant;
            this.NrRooms = numberRestaurants;
            this.Cafeteria = cafeteria;
        }

        public Hotel(string nam, string loc, double ar) : base(nam, loc, ar)
        {

        }

        public short NrRooms { get => nrRooms; set => nrRooms = value; }
        public bool Cafeteria { get => cafeteria; set => cafeteria = value; }
        internal Restaurant Restaurant { get => restaurant; set => restaurant = value; }

        public override void Status()
        {
            Console.WriteLine(" Hotel \n Name: {12} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of rooms: {11} ", this.IdProperty, this.Value, this.Area, this.Location, this.WaterExpenses, this.LightExpenses, this.GasExpenses, this.Incomes, this.Outcomes, this.TotalIncome, this.TotalOutcome, this.NrRooms, this.Name);

            if (this.Cafeteria == true)
            {
                Console.WriteLine(" Cafeteria: yes");
            }

            if (this.Cafeteria == false)
            {
                Console.WriteLine(" Cafeteria: no");
            }
        }
    }
}
