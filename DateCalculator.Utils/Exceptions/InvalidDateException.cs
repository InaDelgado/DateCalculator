using System;

namespace DateCalculator.Utils.Exceptions
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message)
            : base(message)
        {
        }

        public InvalidDateException()
            : this("Date informed is not valid")
        {
        }
    }
}
