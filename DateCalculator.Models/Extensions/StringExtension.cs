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
            string pattern = "[0-9]{2}[/][0-9]{2}[/][0-9]{4}[ ][0-9]{2}[:][0-9]{2}";

            return Regex.IsMatch(enteredDate, pattern);
        }

        public static bool FormatAmountIsMatch(this string enteredAmount)
        {
            string pattern = "[0-9]{1,5}";

            return Regex.IsMatch(enteredAmount, pattern);
        }

        public static string GetDateString(this string entered)
        {
            int indice = entered.IndexOf(" ");
            return entered.Substring(0, indice);
        }

        public static string GetTimeString(this string entered)
        {
            int indice = entered.IndexOf(" ") + 1;
            return entered.Substring(indice);
        }

        public static int GetDay(this string entered)
        {
            var date = entered.GetDateString();
            int indice = date.IndexOf("/");
            return int.Parse(date.Substring(0, indice));
        }

        public static int GetMonth(this string entered)
        {
            var date = entered.GetDateString();
            int indice = date.IndexOf("/") + 1;
            return int.Parse(date.Substring(indice, 2));
        }

        public static int GetYear(this string entered)
        {
            var date = entered.GetDateString();
            int indice = date.IndexOf("/") + 1;
            var firstPart = date.Substring(indice);
            var secondPart = firstPart.Substring(indice);

            return int.Parse(secondPart);
        }

        public static int GetHour(this string entered)
        {
            var time = entered.GetTimeString();
            int indice = time.IndexOf(":");
            return int.Parse(time.Substring(0, indice));
        }

        public static int GetMinute(this string entered)
        {
            var time = entered.GetTimeString();
            int indice = time.IndexOf(":") + 1;
            return int.Parse(time.Substring(indice));
        }
    }
}
