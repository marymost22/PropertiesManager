using System;
using AbstractProperty;

namespace Frm
{
    class Farm : Property
    {
        public Farm(string nam, double val, double ar, string loc, double we, double le, double ge, double inc, double outc) : base(nam, val, ar, loc, we, le, ge, inc, outc)
        {
        }

        public Farm(string nam, string loc, double ar) : base(nam, loc, ar)
        {

        }

        public override void Status()
        {
            Console.WriteLine(" Farm \n Name: {11} \n ID: {0} \n Value: {1} \n Area: {2} \n Location: {3} \n Water expenses: {4} \n Light expenses: {5} \n Gas expenses: {6} \n Monthly Income: {7} \n Monthly Outcome: {8} \n Total Income: {9} \n Total Outcome: {10}  ", this.IdProperty, this.Value, this.Area, this.Location, this.WaterExpenses, this.LightExpenses, this.GasExpenses, this.Incomes, this.Outcomes, this.TotalIncome, this.TotalOutcome, this.Name);
        }

    }
}