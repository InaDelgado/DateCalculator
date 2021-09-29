using System.Linq;

namespace DateCalculator.Models
{
    public abstract class Calculate
    {
        protected int IndexOfThePossibleMonth { get; set; }
        protected long DaysRemaining { get; set; }

        public abstract int DaysOfCalculatedMonth(int month);

        public abstract long CalculateYear();

        public abstract long DaysRemainingForTheCalculatedYear();

        public long DifferenceOfDays()
        => DaysRemaining - Consts.DAYSFORMONTH.ElementAt(IndexOfThePossibleMonth);

        public bool NextMonth()
        => DifferenceOfDays() > 0;
    }
}
