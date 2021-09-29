using System.Collections.Generic;

namespace DateCalculator.Models
{
    public class Consts
    {
        public static readonly List<int> DAYSEACHMONTH = new List<int> { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static readonly List<int> DAYSFORMONTH = new List<int> { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
    }
}
