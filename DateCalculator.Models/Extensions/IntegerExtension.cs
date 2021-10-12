using System.Linq;

namespace DateCalculator.Models.Extensions
{
    public static class IntegerExtension
    {
        public static int DaysOfMonth(this int value)
        {
            return Consts.DAYSEACHMONTH.ElementAt(value);
        }
    }
}
