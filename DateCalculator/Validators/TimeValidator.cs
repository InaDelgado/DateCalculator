using DateCalculator.Models.Extensions;

namespace DateCalculator.System
{
    public static class TimeValidator
    {
        public static bool IsValid(string dateTime)
        {
            int hour = dateTime.GetHour();
            int minute = dateTime.GetMinute();

            if(!ValidateTime(hour, minute))
                throw new InvalidTimeException();

            return true;
        }

        private static bool HourIsValid(int hour)
        => (hour >= 0 && hour < 24);

        private static bool MinuteIsValid(int? minute)
        => (minute >= 0 && minute <= 59);

        private static bool ValidateTime(int hour, int minute)
        => HourIsValid(hour) & MinuteIsValid(minute);
    }
}
