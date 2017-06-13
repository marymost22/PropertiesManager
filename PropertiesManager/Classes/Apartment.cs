
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

        public Apartment(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short floors, short nrRooms, short nrBathrooms, bool balcony, bool garage) : base(nam, val, ar, loc, we, le, ge, inc, outc)
        {
            this.Floors = floors;
            this.NrRooms = nrRooms;
            this.NrBathrooms = nrBathrooms;
            this.Balcony = balcony;
            this.Garage = garage;
        }

        public Apartment(string nam, string loc, double ar) : base(nam, loc, ar)
        {

        }

        public short Floors { get => floors; set => floors = value; }
        public short NrRooms { get => nrRooms; set => nrRooms = value; }
        public short NrBathrooms { get => nrBathrooms; set => nrBathrooms = value; }
        public bool Balcony { get => balcony; set => balcony = value; }
        public bool Garage { get => garage; set => garage = value; }

        public override void Status()
        {
            Console.WriteLine(" Apartment \n Name: {14} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of floors: {11} \n Number of rooms: {12} \n Number of bathrooms: {13}", this.IdProperty, this.Value, this.Area, this.Location, this.WaterExpenses, this.LightExpenses, this.GasExpenses, this.Incomes, this.Outcomes, this.TotalIncome, this.TotalOutcome, this.Floors, this.NrRooms, this.NrBathrooms, this.Name);
            
            if(Balcony == true)
            {
                Console.WriteLine(" Balcony: yes");
            }

            if(Balcony == false)
            {
                Console.WriteLine(" Balcony: no");
            }

            if(Garage == true)
            {
                Console.WriteLine(" Garage: yes");
            }

            if(Garage == false)
            {
                Console.WriteLine(" Garage: no");
            }
        }
    }
}
