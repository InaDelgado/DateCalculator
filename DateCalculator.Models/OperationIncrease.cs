using System;

namespace DateCalculator.Models
{
    public class OperationIncrease : Operation
    {
        public DateTime Calculate(string date, long value)
        {
            try
            {

                //work in progress
            }
            catch (Exception)
            {

                throw;
            }

            return new DateTime();
        }

        public override DateTime Calculate(Date date, string value)
        {
            throw new NotImplementedException();
        }
    }
}
