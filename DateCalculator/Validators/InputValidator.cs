using System;

namespace DateCalculator.System
{
    public class InputValidator
    {
        public string Operation { get; }
        public string DateTime { get; }
        public string Amount { get; }

        public InputValidator(string operation, string dateTime, string amount)
        {
            Operation = operation;
            DateTime = dateTime;
            Amount = amount;
        }

        public bool InputIsValid()
        => ValidateInputData() && ValidateDateTime();

        public bool ValidateInputData()
        {
            return IsNotEmpty()
                && FormatValidator.IsValid(DateTime, Amount)
                && OperationValidator.IsValid(Operation);
        }
        public bool ValidateDateTime()
        {
            return DateValidator.IsValid(DateTime)
                && TimeValidator.IsValid(DateTime);
        }

        public bool IsNotEmpty()
        {
            if (string.IsNullOrWhiteSpace(DateTime))
                throw new ArgumentNullException("Date can't be null");

            if (string.IsNullOrWhiteSpace(Amount))
                throw new ArgumentNullException("Amount can't be null");

            return true;
        }
    }
}
