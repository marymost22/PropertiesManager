//A whole flat with all of its apartments

using System;
using AbstractProperty;

namespace Flt
{
    class Flat : Property
    {
       private short garages;
       private short nrApartments;
       private short nrFloors;
       private bool elevator;

        public Flat(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short gr, short na, short nf, bool elevator) : base(nam, val, ar, loc, we, le, ge, inc, outc)
        {
            this.Garages = gr;
            this.NrApartments = na;
            this.NrFloors = nf;
            this.Elevator = elevator;
        }

        public Flat(string nam, string loc, double ar) : base(nam, loc, ar)
        {

        }

        public short Garages { get => garages; set => garages = value; }
        public short NrApartments { get => nrApartments; set => nrApartments = value; }
        public short NrFloors { get => nrFloors; set => nrFloors = value; }
        public bool Elevator { get => elevator; set => elevator = value; }

        public override void Status()
        {
            Console.WriteLine(" Flat \n Name: {14} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of garages: {11} \n Number of floors: {12} \n Number of apartments: {13}", this.IdProperty, this.Value, this.Area, this.Location, this.WaterExpenses, this.LightExpenses, this.GasExpenses, this.Incomes, this.Outcomes, this.TotalIncome, this.TotalOutcome, this.Garages, this.NrFloors, this.NrApartments,this.Name);
            
            if(Elevator == true)
            {
                Console.WriteLine(" Elevator: yes");
            }

            if(Elevator == false)
            {
                Console.WriteLine(" Elevator: no");
            }
        }
    }
}
