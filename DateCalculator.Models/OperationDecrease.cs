using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
    /// <summary>
    /// Represents the concrete class for Decrease Operation
    /// </summary>
    public class OperationDecrease : Operation
    {
        private readonly string _operationType;
        private Date _dateInput;
        private long _amount;
        private int _spentDays;

        public OperationDecrease(Date dateInput, long amount)
        {
            _operationType = "Decrease";
            _dateInput = dateInput;
            _amount = amount;
        }

        public override string OperationType
        {
            get { return _operationType; }
        }

        public override Date DateInput
        {
            get { return _dateInput; }
            set { _dateInput = value; }
        }

        public override long Amount 
        { 
            get { return _amount; } 
            set { _amount = value; }
        }

        /// <summary>
        /// Defines which operation should be performed
        /// </summary>
        /// <param name="date"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override string Calculate()
        {
            try
            {
                _spentDays = DaysSpentInTheYear();

                var decrease = new Decrease(_amount, _spentDays, _dateInput.Year);

                return $"{decrease.CalculateNewDate()} {_dateInput.Hour}:{_dateInput.Minute}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DaysSpentInTheYear()
        {
            var amountDaysUntilPreviousMonth = Consts.DAYSFORMONTH.FindValue(DateInput.Month - 1);

            return (amountDaysUntilPreviousMonth + DateInput.Day);
        }
    }
}
