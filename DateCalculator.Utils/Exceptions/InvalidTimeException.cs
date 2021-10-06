using System;

namespace DateCalculator.Utils.Exceptions
{
    public class InvalidTimeException : Exception
    {
        public InvalidTimeException(string message)
            : base(message)
        {
        }

        public InvalidTimeException()
            : this("That's a invalid time")
        {
        }
    }
}
