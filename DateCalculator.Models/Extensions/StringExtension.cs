using System.Text.RegularExpressions;

namespace DateCalculator.Models.Extensions
{
    public static class StringExtension
    {
        public static string FormatPartDate(this string value)
        {
            return (value.Length == 1) ? string.Concat("0", value) : value;
        }

        public static bool FormatDateIsMatch(this string enteredDate)
        {
            string pattern = "[0-9]{2}[/][0-9]{2}[/][0-9]{4}";

            return Regex.IsMatch(enteredDate, pattern);
        }

        public static bool FormatAmountIsMatch(this string enteredAmount)
        {
            string pattern = "[0-9]{1,5}";

            return Regex.IsMatch(enteredAmount, pattern);
        }

        public static int GetDay(this string entered)
        {
            int indice = entered.IndexOf("/");
            return int.Parse(entered.Substring(0, indice));
        }

        public static int GetMonth(this string entered)
        {
            int indice = entered.IndexOf("/") + 1;
            return int.Parse(entered.Substring(indice, 2));
        }

        public static int GetYear(this string entered)
        {
            int indice = entered.IndexOf("/") + 1;
            var firstPart = entered.Substring(indice);
            var secondPart = firstPart.Substring(indice);

            return int.Parse(secondPart);
        }
    }
}
