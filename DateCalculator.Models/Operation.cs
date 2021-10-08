using DateCalculator.Models.Extensions;

namespace DateCalculator.Models
{
    public abstract class Operation
    {
        protected Date DateInput { get; set; }
        protected int SpentDaysInTheYear { get; set; }
        protected long Amount;

        public abstract string Calculate(Date date, string value);

        public void BeforeCalculate(Date date, string amount)
        {
            DateInput = date;
            long.TryParse(amount, out Amount);
            SpentDaysInTheYear = DaysSpentInTheYear();
        }

        public int DaysSpentInTheYear()
        {
            var amountDaysUntilPreviousMonth = Consts.DAYSFORMONTH.FindValue(DateInput.Month - 1);

            return (amountDaysUntilPreviousMonth + DateInput.Day);
        }
    }
}
