namespace DateCalculator.Models
{
    public abstract class Calculate
    {
        public abstract long DaysRemaining { get; set; }

        public abstract long CalculateYear();

        public abstract long DaysRemainingForTheCalculatedYear();

        public abstract long CalculateDifferenceOfDays();

        public abstract bool IsNextMonth();
    }
}
