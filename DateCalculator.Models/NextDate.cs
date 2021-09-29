using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.System
{
    public class NextDate
    {
        public char Op { get; set; }
        //public Increase Increase { get; set; }
        //public Decrease Decrease { get; set; }


        public NextDate(string date, char op, long value)
        {
            this.Op = op;
            //this.Increase = new Increase(date, value);
            //this.Decrease = new Decrease(date, value);
        }

        public string DateEnded(long totalMinutes)
        {
            return this.ChooseOperation(totalMinutes);
        }

        public string ChooseOperation(long totalMinutes)
        {
            return "";
            //if ("+".Equals(Op.ToString())) return Increase.Accomplish(totalMinutes);
            //else return Decrease.Accomplish(totalMinutes);
        }
    }
}
