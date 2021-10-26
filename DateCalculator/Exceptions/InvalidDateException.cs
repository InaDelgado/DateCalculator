using System;

namespace DateCalculator.System
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message)
            : base(message)
        {
        }

        public InvalidDateException()
            : this("That's a invalid Date")
        {
        }
    }
}
