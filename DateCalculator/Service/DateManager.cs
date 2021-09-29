using DateCalculator.Models;
using DateCalculator.Utils;
using DateCalculator.Utils.Extensions;
using DateCalculator.Utils.Exceptions;
using DateCalculator.Utils.Validators;
using System;

namespace DateCalculator.System
{
    /// <summary>
    /// Represents the operation's Strategy Manager
    /// </summary>
    public class DateManager
    {
        public string Date { get; }
        public string Operation { get; }
        public string Amount { get; }
        private DateInput DateInput { get; set; }
        private Operation OperationStrategy { get; set; }

        /// <summary>
        /// Create an instance from Strategy Manager with the used arguments
        /// </summary>
        /// <param name="date">Represents an entered date, and cannot be empty</param>
        /// <param name="operation">Represents an entered operation to increase or to decrease the date, and cannot be empty</param>
        /// <param name="amount">/Represents an entered amount to performe the date calculation</param>
        public DateManager(string date, string operation, string amount)
        {
            Date = date;
            Operation = operation;
            Amount = amount;
        }

        /// <summary>
        /// Choose the strategy should be used according to the reported operation
        /// </summary>
        public void ToManage()
        {
            switch (Operation)
            {
                case nameof(ConstsUtils.INCREASE):
                    OperationStrategy = new OperationIncrease();
                    break;
                case nameof(ConstsUtils.DECREASE):
                    OperationStrategy = new OperationDecrease();
                    break;
                default:
                    throw new InvalidInputOperationException();
            }
        }

        /// <summary>
        /// Performe calculation according the chosen strategy
        /// </summary>
        /// <returns>Return the calculated date</returns>
        public DateTime ExecuteStrategy()
        => OperationStrategy.Calculate(DateInput, Amount);

        public void ValidateDateTime()
        {
            try
            {
                var validator = new ValidatorInput(Operation, Date, Amount, DateInput);

                validator.InputIsValid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PopulateDate()
        {
            DateInput = new DateInput
            {
                Day = Date.GetDay(),
                Month = Date.GetMonth(),
                Year = Date.GetYear(),
                Hour = Date.GetHour(),
                Minute = Date.GetMinute()
            };
        }
    }
}