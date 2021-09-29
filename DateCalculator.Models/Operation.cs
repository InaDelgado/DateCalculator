using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    public abstract class Operation
    {
        protected DateInput DateInput { get; set; }
        protected int SpentDaysInTheYear { get; set; }
        protected long Amount;

        public abstract DateTime Calculate(DateInput date, string value);

        public void BeforeCalculate(DateInput date, string amount)
        {
            long.TryParse(amount, out Amount);
            SpentDaysInTheYear = DaysSpentInTheYear();
            DateInput = date;
        }

        public int DaysSpentInTheYear()
        => (DaysUntilPreviousMonth() + DateInput.Day);

        public int DaysUntilPreviousMonth()
        => Consts.DAYSFORMONTH.FindValue(DateInput.Month - 1);
    }
}
