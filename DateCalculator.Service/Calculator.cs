using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.System
{
    public class Calculator
    {
        public string Date { get; }
        public string Operation { get; }

        public string Amount { get; set; }

        public Calculator(string date, string operation, string amount)
        {
            Date = date;
            Operation = operation;
            Amount = amount;
        }

        public DateTime CalculateDate()
        {
            switch (Operation)
            {
                case "+":

                    break;
                case "-":
                    break;
            }
        }
    }
}
