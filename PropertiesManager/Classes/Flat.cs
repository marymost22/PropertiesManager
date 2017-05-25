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

        public Flat() : base()
        {

        }

        public Flat(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc, short gr, short na, short nf, Existence el) : base(nam, val, ar, loc, we, le, ge, inc, outc)
        {
            garages = gr;
            nrApartments = na;
            nrFloors = nf;

            if (el == Existence.yes)
            {

                elevator = true;
            }
            else
            {
                elevator = false;
            }
        }

         ~Flat() { }

        public override void Status()
        {
            Console.WriteLine(" Flat \n Name: {14} \n ID:{0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10} \n Number of garages: {11} \n Number of floors: {12} \n Number of apartments: {13}", this.idProperty, this.value, this.area, this.location, this.waterExpenses, this.lightExpenses, this.gasExpenses, this.incomes, this.outcomes, this.totalIncome, this.totalOutcome, this.garages, this.nrFloors, this.nrApartments,this.name);
            
            if(elevator == true)
            {
                Console.WriteLine(" Elevator: yes");
            }

            if(elevator == false)
            {
                Console.WriteLine(" Elevator: no");
            }
        }
    }
}
