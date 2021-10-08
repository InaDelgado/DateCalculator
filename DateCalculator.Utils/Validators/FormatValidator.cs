using DateCalculator.Utils.Exceptions;
using DateCalculator.Utils.Extensions;

namespace DateCalculator.Utils.Validators
{
    public static class FormatValidator
    {
        public static bool IsValid(string dateTime, string amount)
        => IsValidFormatDateTime(dateTime) && IsValidFormatAmount(amount);

        public static bool IsValidFormatDateTime(string dateTime)
        {
            if (!dateTime.FormatDateIsMatch())
                throw new FormatStringException("Input date and time format is invalid");

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
