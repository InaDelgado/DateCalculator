using System;

namespace DateCalculator.Models
{
    /// <summary>
    /// Represents the concrete class for Decrease Operation
    /// </summary>
    public class OperationDecrease : Operation
    {
        /// <summary>
        /// Defines which operation should be performed
        /// </summary>
        /// <param name="date"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override string Calculate(Date date, string value)
        {
            try
            {
                BeforeCalculate(date, value);

                var decrease = new Decrease(Amount, SpentDaysInTheYear, DateInput.Year);

                return $"{decrease.CalculateNewDate()} {DateInput.Hour}:{DateInput.Minute}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
