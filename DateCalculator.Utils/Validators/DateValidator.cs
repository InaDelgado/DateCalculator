using DateCalculator.Utils.Exceptions;
using DateCalculator.Utils.Extensions;

namespace DateCalculator.Utils.Validators
{
    public static class DateValidator
    {
        public static bool IsValid(string dateTime)
        {
            int day = dateTime.GetDay();
            int month = dateTime.GetMonth();
            int year = dateTime.GetYear();

            if(!DateIsValid(day, month, year))
                throw new InvalidDateException();

            return true;
        }

        private static bool DayIsValid(int day, int month)
        => (day >= 1);
        //=> (day >= 1 && day <= DaysOfTheMonthValidator.DaysOfCurrentMonth(month));

        private static bool MonthIsValid(int month)
        => (month >= 1 && month <= 12);

        private static bool YearIsValid(int year)
        => (year > 0 && year < 9999);

        private static bool DateIsValid(int day, int month, int year)
        => (DayIsValid(day, month) && MonthIsValid(month) && YearIsValid(year));
    }
}
