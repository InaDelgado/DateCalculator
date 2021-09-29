using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.Utils.Exceptions
{
    public class InvalidInputOperationException : Exception
    {

        public InvalidInputOperationException(string message) 
            : base(message)
        {
        }

        public InvalidInputOperationException()
            : this("That's a invalid operation")
        {
        }
    }
}
