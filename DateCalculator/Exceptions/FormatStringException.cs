using System;

namespace DateCalculator.System
{
    public class FormatStringException : Exception
    {
        public FormatStringException(string message)
            : base(message)
        {
        }
    }
}
