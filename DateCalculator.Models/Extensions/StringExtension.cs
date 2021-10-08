using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.Models.Extensions
{
    public static class StringExtension
    {
        public static string FormatPartDate(this string value)
        {
            return (value.Length == 1) ? string.Concat("0", value) : value;
        }
    }
}
