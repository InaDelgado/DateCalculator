using System;

namespace DateCalculator.System
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
