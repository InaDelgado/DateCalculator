using System;

namespace DateCalculator.Utils.Exceptions
{
    public class FormatStringException : Exception
    {
        public FormatStringException(string message)
            : base(message)
        {
        }
    }
}
