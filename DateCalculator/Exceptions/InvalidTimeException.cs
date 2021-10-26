using System;

namespace DateCalculator.System
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
