using System;
using System.Collections.Generic;
using System.Text;

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
