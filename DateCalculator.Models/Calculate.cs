using System.Linq;

namespace DateCalculator.Models
{
    public abstract class Calculate
    {
        protected long DaysRemaining;

        public abstract int DaysOfCalculatedMonth(int month);

        public abstract long CalculateYear();

        public abstract long DaysRemainingForTheCalculatedYear();

        public long CalculateDifferenceOfDays(int index)
        => DaysRemaining - Consts.DAYSFORMONTH.ElementAt(index);

        public bool IsNextMonth(int index)
        => CalculateDifferenceOfDays(index) > 0;
    }
}
