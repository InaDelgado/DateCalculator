using DateCalculator.Models.Extensions;

namespace DateCalculator.System
{
    public static class FormatValidator
    {
        public static bool IsValid(string dateTime, string amount)
        => IsValidFormatDateTime(dateTime) && IsValidFormatAmount(amount);

        public static bool IsValidFormatDateTime(string dateTime)
        {
            if (!dateTime.FormatDateIsMatch())
                throw new FormatStringException("Input date format is not valid");

            return true;
        }

        public static bool IsValidFormatAmount(string amount)
        {
            if(!amount.FormatAmountIsMatch())
                throw new FormatStringException("Input amount format is invalid");

            return true;
        }
    }
}
