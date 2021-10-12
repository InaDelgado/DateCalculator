namespace DateCalculator.Models.Factories
{
    public class OperationDecreaseFactory : IOperationFactory
    {
        private Date _dateInput;
        private long _amount;

        public OperationDecreaseFactory(Date dateInput, long amount)
        {
            _dateInput = dateInput;
            _amount = amount;
        }

        public Operation FindOperation()
        {
            return new OperationDecrease(_dateInput, _amount);
        }
    }
}
