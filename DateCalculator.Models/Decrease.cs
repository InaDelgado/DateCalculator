using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    internal class Decrease : CalculateDecrease
    {
        private Date _dateInput;

        public Decrease(long amount, int spentDays, Date dateInput)
            : base(amount, spentDays)
        {
            _dateInput = dateInput;
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
            var inputYear = _dateInput.Year;
            var yearsToDecrease = CalculateYear();
            var newYear = (yearsToDecrease > inputYear) ? 0 : (inputYear - yearsToDecrease);

            return newYear.ToString();
        }

        private string NewMonth()
        {
            bool isNextMonth = IsNextMonth();
            int adjustedMonth = (_indexMonth + 1);
            int monthFromRange = _indexMonth;
            int newMonth = (isNextMonth) ? adjustedMonth : monthFromRange;

            return newMonth.ToString();
        }

        private string NewDay()
        {
            bool nextMonth = IsNextMonth();
            var difference = Math.Abs(CalculateDifferenceOfDays());
            var daysOfNewMonth = int.Parse(NewMonth()).DaysOfMonth();
            var newDay = (nextMonth) ? difference : (daysOfNewMonth - difference);

            return newDay.ToString();
        }

    }
}
