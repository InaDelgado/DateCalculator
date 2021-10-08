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
        private string InputDate { get; }
        private string Operation { get; }
        private string Amount { get; }
        private Date Date { get; set; }
        private Operation OperationStrategy { get; set; }

        /// <summary>
        /// Create an instance from Strategy Manager with the used arguments
        /// </summary>
        /// <param name="date">Represents an entered date, and cannot be empty</param>
        /// <param name="operation">Represents an entered operation to increase or to decrease the date, and cannot be empty</param>
        /// <param name="amount">/Represents an entered amount to performe the date calculation</param>
        public DateManager(string date, string operation, string amount)
        {
            InputDate = date;
            Operation = operation;
            Amount = amount;
        }

        /// <summary>
        /// Choose the strategy should be used according to the reported operation
        /// </summary>
        public void ToManage()
        {
            try
            {
                if (Operation.Equals(ConstsUtils.INCREASE))
                    OperationStrategy = new OperationIncrease();

                if (Operation.Equals(ConstsUtils.DECREASE))
                    OperationStrategy = new OperationDecrease();
            }
            catch (Exception)
            {
                throw new InvalidInputOperationException();
            }
        }

        /// <summary>
        /// Performe calculation according the chosen strategy
        /// </summary>
        /// <returns>Return the calculated date</returns>
        public string ExecuteCalculation()
        => OperationStrategy.Calculate(Date, Amount);

        public void ValidateDateTime()
        {
            try
            {
                var validator = new InputValidator(Operation, InputDate, Amount);

                if(validator.InputIsValid())
                    PopulateDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PopulateDate()
        {
            Date = new Date
            {
                Day = InputDate.GetDay(),
                Month = InputDate.GetMonth(),
                Year = InputDate.GetYear(),
                Hour = InputDate.GetHour(),
                Minute = InputDate.GetMinute()
            };
        }
    }
}