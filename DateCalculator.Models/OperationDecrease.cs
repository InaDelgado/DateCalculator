using DateCalculator.Models.Extensions;
using System;

namespace DateCalculator.Models
{
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

        public override string Calculate()
        {
            try
            {
                _spentDays = DaysSpentInTheYear();

                var decrease = new Decrease(_amount, _spentDays, _dateInput);

                return decrease.CalculateNewDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DaysSpentInTheYear()
        {
            var amountDaysUntilPreviousMonth = Consts.DAYSFORMONTH.FindValue(_dateInput.Month - 1);

            return (amountDaysUntilPreviousMonth + _dateInput.Day);
        }
    }
}
