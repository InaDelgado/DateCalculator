using System;

namespace DateCalculator.Models
{
    /// <summary>
    /// Represents the concrete class for Decrease Operation
    /// </summary>
    public class OperationDecrease : Operation
    {
        private int DaysRemainingForTheCalculatedYear { get; }

        /// <summary>
        /// Defines which operation should be performed
        /// </summary>
        /// <param name="date"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override DateTime Calculate(DateInput date, string value)
        {
            try
            {
                base.BeforeCalculate(date, value);

                //var decrease = new Decrease(Amount, base.SpentDaysInTheYear);

                return new DateTime();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
