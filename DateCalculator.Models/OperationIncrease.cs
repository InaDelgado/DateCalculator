using System;
using System.Collections.Generic;
using System.Text;

namespace DateCalculator.Models
{
    public class OperationIncrease : Operation
    {
        public DateTime Calculate(string date, long value)
        {
            try
            {
                var increase = new Increase(date, value);
            }
            catch (Exception)
            {

                throw;
            }

            return new DateTime();
        }

        public override DateTime Calculate(DateInput date, string value)
        {
            throw new NotImplementedException();
        }
    }
}
