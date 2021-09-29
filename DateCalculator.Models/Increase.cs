using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Models
{
    internal class Increase
    {
        //public ParseDate ParseDate { get; set; }
        //public ParseTime ParseTime { get; set; }
        public int Value { get; set; }
        public string Date { get; set; }
        public int TotalIncreased { get; set; }

        public Increase(string date, long value)
        {
            this.Value = int.Parse(value.ToString());
            this.Date = date;
            //this.ParseDate = new ParseDate(date);
            //this.ParseTime = new ParseTime(date);
        }
        public string Accomplish(long totalMinutes)
        {
            this.TotalIncreased = this.AddMinutes(totalMinutes);
            return "teste";
        }

        public int AddMinutes(long totalMinutes)
        {
            return int.Parse(totalMinutes.ToString()) + Value;
        }
    }
}
