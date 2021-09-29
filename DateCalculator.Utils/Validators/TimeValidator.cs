namespace DateCalculator.Utils
{
    public static class TimeValidator
    {
        public static bool IsValid(int hour, int minute)
        => ValidateTime(hour, minute);

        private static bool HourIsValid(int hour)
        => (hour >= 0 && hour < 24);

        private static bool MinuteIsValid(int? minute)
        => (minute >= 0 && minute <= 59);

        private static bool ValidateTime(int hour, int minute)
        => HourIsValid(hour) & MinuteIsValid(minute);
    }
}
