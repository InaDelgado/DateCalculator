using DateCalculator.Models.Extensions;

namespace DateCalculator.Models
{
    public abstract class Operation
    {
        public abstract string OperationType { get;  }
        public abstract Date DateInput { get; set; }
        public abstract long Amount { get; set; }
        public abstract string Calculate();
    }
}
