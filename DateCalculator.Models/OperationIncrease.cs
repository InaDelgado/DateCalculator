using System;

namespace DateCalculator.Models
{
    public class OperationIncrease : Operation
    {
        private readonly string _operationType;
        private Date _dateInput;
        private long _amount;
        private int _spentDays;

        public OperationIncrease(Date dateInput, long amount)
        {
            _operationType = "Increase";
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

                //work in progress
            }
            catch (Exception)
            {

                throw;
            }

            return "";
        }
    }
}
