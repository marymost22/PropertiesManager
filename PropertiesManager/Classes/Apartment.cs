//Single (just like most of us...) apartment. Luxurious ones can have their own floors and assigned garage hence the members.

using System;
using AbstractProperty;

namespace Aprtmnt 
{
    class Apartment : Property 
    {
        private short floors;
        private short nrRooms;
        private short nrBathrooms;
        private bool balcony;
        private bool garage;


        public Apartment() : base()
        {

        }

        public Apartment( string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short fl, short nr, short nb, Existence bal, Existence gr) : base (nam, val, ar, loc, we, le, ge, inc, outc)
        {
            

            floors = fl;
            nrRooms = nr;
            nrBathrooms = nb;

            if (bal == Existence.yes)
            {

                balcony = true;
            }
            else
            {
                balcony = false;
            }

            if(gr == Existence.yes)
            {
                garage = true;
            }
            else
            {
                garage = false;
            }
        }

        ~Apartment() {}


        public override void Status()
        {
            Console.WriteLine(" Apartment \n Name: {14} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of floors: {11} \n Number of rooms: {12} \n Number of bathrooms: {13}", this.idProperty, this.value, this.area, this.location, this.waterExpenses, this.lightExpenses, this.gasExpenses, this.incomes, this.outcomes, this.totalIncome, this.totalOutcome, this.floors, this.nrRooms, this.nrBathrooms, this.name);
            
            if(balcony == true)
            {
                Console.WriteLine(" Balcony: yes");
            }

            if(balcony == false)
            {
                Console.WriteLine(" Balcony: no");
            }

            if(garage == true)
            {
                Console.WriteLine(" Garage: yes");
            }

            if(garage == false)
            {
                Console.WriteLine(" Garage: no");
            }
        }
    }
}
