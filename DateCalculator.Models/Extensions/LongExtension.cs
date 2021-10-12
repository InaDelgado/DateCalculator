using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.Models.Extensions
{
    public static class LongExtension
    {
        public static int TakeMonth(this long value)
        {
            return Consts.DAYSFORMONTH.FindIndexRange(value);
        }
    }
}
