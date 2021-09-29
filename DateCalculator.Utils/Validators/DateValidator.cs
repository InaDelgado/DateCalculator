namespace DateCalculator.Utils.Validators
{
    public static class DateValidator
    {
        public static bool IsValid(int day, int month, int year)
        => DateTimeIsValid(day, month, year);

        private static bool DayIsValid(int day, int month)
        => (day >= 1);
        //=> (day >= 1 && day <= DaysOfTheMonthValidator.DaysOfCurrentMonth(month));

        private static bool MonthIsValid(int month)
        => (month >= 1 && month <= 12);

        private static bool YearIsValid(int year)
        => (year > 0 && year < 9999);

        private static bool DateTimeIsValid(int day, int month, int year)
        => (DayIsValid(day, month) && MonthIsValid(month) && YearIsValid(year));
    }
}
