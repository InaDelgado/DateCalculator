using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    public class Replace
    {
        public DateInput DateInput { get; }

        public Replace(DateInput dateInput)
        {
            DateInput = dateInput;
        }

        //public long DateToMinutes()
        //=> DaysToMinutes() + TimeToMinutes();

        //public long TimeToMinutes()
        //=> (Hour * 60) + Minute;

        //public long DaysToMinutes()
        //=> DaysSpentInTheYear() * 1440;

        public int DaysSpentInTheYear()
        => (DaysUntilPreviousMonth() + DateInput.Day);

        public int DaysUntilPreviousMonth()
        => Consts.DAYSFORMONTH.FindValue(DateInput.Month - 1);
    }
}
