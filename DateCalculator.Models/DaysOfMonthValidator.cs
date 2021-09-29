using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.Models
{
    public static class DaysOfTheMonthValidator
    {
        public static int DaysOfCurrentMonth(int month)
        {
            var index = int.Parse(month.ToString());

            var daysCurrentMonth = Consts.DAYSFORMONTH[index];
            var daysPreviousMonth = Consts.DAYSFORMONTH[index - 1];

            return (daysCurrentMonth - daysPreviousMonth);
        }
    }
}
