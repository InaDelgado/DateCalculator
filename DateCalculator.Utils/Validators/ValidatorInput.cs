using DateCalculator.Models;
using DateCalculator.Utils.Exceptions;
using DateCalculator.Utils.Extensions;
using System;

namespace DateCalculator.Utils.Validators
{
    public class ValidatorInput
    {
        public string Operation { get; }
        public string DateTime { get; }
        public string Amount { get; }
        public DateInput DateInput { get; }

        public ValidatorInput(string operation, string dateTime, string amount, DateInput dateInput)
        {
            Operation = operation;
            DateTime = dateTime;
            Amount = amount;
            DateInput = dateInput;
        }

        public bool InputIsValid()
        => ValidateOperation() && ValidateDateTime();

        public bool ValidateOperation()
        {
            if (!OperationValidator.IsValid(Operation))
                throw new InvalidInputOperationException();

            return true;
        }

        public bool ValidateEnteredData()
        {
            if (string.IsNullOrWhiteSpace(DateTime))
                throw new ArgumentNullException("Date can't be null");

            if (string.IsNullOrWhiteSpace(Amount))
                throw new InvalidDateException("Amount can't be null");

            if (!FormatValidator.IsValid(DateTime))
                throw new InvalidDateException("Date and time format is invalid");

            return true;
        }

        public bool ValidateDate()
        {
            if (!DateValidator.IsValid(DateInput.Day, DateInput.Month, DateInput.Year))
                throw new InvalidDateException();

            return true;
        }

        public bool ValidateTime()
        {
            if (!TimeValidator.IsValid(DateInput.Hour, DateInput.Minute))
                throw new InvalidTimeException();

            return true;
        }

        public bool ValidateDateTime()
        => ValidateDate() && ValidateDateTime();
    }
}
