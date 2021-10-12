namespace DateCalculator.Models.Factories
{
    public class OperationIncreaseFactory : IOperationFactory
    {
        private Date _dateInput;
        private long _amount;

        public OperationIncreaseFactory(Date dateInput, long amount)
        {
            _dateInput = dateInput;
            _amount = amount;
        }

        public Operation FindOperation()
        {
            return new OperationIncrease(_dateInput, _amount);
        }
    }
}
