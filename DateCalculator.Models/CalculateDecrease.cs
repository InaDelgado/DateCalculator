using DateCalculator.Models.Extensions;
using System.Linq;

namespace DateCalculator.Models
{
    public class CalculateDecrease : Calculate
    {
        private long _amount;
        private long _spentDays;
        protected int _indexMonth;
        private long _daysRemaining;

        public CalculateDecrease(long amount, long spentDays)
        {
            _amount = amount;
            _spentDays = spentDays;
            _indexMonth = DaysRemainingForTheCalculatedYear().TakeMonth();
            _daysRemaining = DaysRemainingForTheCalculatedYear();
        }

        public override long DaysRemaining 
        {
            get { return _daysRemaining; } 
            set { _daysRemaining = value; }
        }

        private long DecreaseDays(long amount, long days)
        {
            return (amount > days) ? (amount - days) : (days - amount);
        }

        public override long CalculateYear()
        {
            return DecreaseDays(_amount, _spentDays) / 365;
        }

        public override long DaysRemainingForTheCalculatedYear()
        { 
            return DecreaseDays(_amount, _spentDays) % 365;
        }

        public override long CalculateDifferenceOfDays()
        {
            return _daysRemaining - Consts.DAYSFORMONTH.ElementAt(_indexMonth);
        }

        public override bool IsNextMonth()
        {
            return CalculateDifferenceOfDays() > 0;
        }
    }
}
