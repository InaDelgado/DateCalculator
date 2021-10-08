using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    internal class Decrease
    {
        public int IndexOfMonth { get; }
        private int Month;
        private CalculateDecrease calculate { get; }
        private long Amount { get; }
        private int SpentDaysInTheYear { get; }
        private int Year { get; }

        public Decrease(long amount, int spentDays, int year)
        {
            Amount = amount;
            SpentDaysInTheYear = spentDays;
            Year = year;
            IndexOfMonth = Consts.DAYSFORMONTH.FindIndexRange(Amount);
            calculate = new CalculateDecrease(Amount, SpentDaysInTheYear, IndexOfMonth);
        }

        public string CalculateNewDate()
        {
            var day = NewDay();
            var month = NewMonth();
            var year = NewYear();

            return $"{day.FormatPartDate()}/{month.FormatPartDate()}/{year.FormatPartDate()}";
        }

        private string NewYear()
        {
            var inputYear = Year;
            var yearsToDecrease = calculate.CalculateYear();
            var newYear = (yearsToDecrease > inputYear) ? 0 : (inputYear - yearsToDecrease);

            return newYear.ToString();
        }

        private string NewMonth()
        {
            bool isNextMonth = calculate.IsNextMonth(IndexOfMonth);
            int adjustedMonth = (IndexOfMonth + 1);
            int monthFromRange = IndexOfMonth;
            int newMonth = (isNextMonth) ? adjustedMonth : monthFromRange;
            Month = newMonth;

            return newMonth.ToString();
        }

        private string NewDay()
        {
            bool nextMonth = calculate.IsNextMonth(IndexOfMonth);
            var difference = Math.Abs(calculate.CalculateDifferenceOfDays(IndexOfMonth));
            var daysOfNewMonth = calculate.DaysOfCalculatedMonth(Month);
            var newDay = (nextMonth) ? difference : (daysOfNewMonth - difference);

            return newDay.ToString();
        }

    }
}
