using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    internal class Decrease : OperationDecrease
    {
        private int IndexOfThePossibleMonth;
        private CalculateDecrease calculate { get; }

        public Decrease()
        {
            IndexOfThePossibleMonth = Consts.DAYSFORMONTH.FindIndexRange(Amount);
            calculate = new CalculateDecrease(Amount, SpentDaysInTheYear, IndexOfThePossibleMonth);
        }

        public long NewYear()
        => (calculate.CalculateYear() > DateInput.Year) ? 0 : DateInput.Year - calculate.CalculateYear();

        public int NewMonth()
        => calculate.NextMonth() ? (IndexOfThePossibleMonth + 1) : IndexOfThePossibleMonth;  

        public long NewDay()
        {
            bool nextMonth = calculate.NextMonth();
            var difference = Math.Abs(calculate.DifferenceOfDays());
            var daysOfNewMonth = calculate.DaysOfCalculatedMonth(NewMonth());
            var newDay = (nextMonth) ? difference : (daysOfNewMonth - difference);

            return newDay;
        }

    }
}
