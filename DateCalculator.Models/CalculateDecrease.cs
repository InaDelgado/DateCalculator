﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateCalculator.Models
{
    public class CalculateDecrease : Calculate
    {
        private long Amount { get; }
        private long SpentDays { get; }

        public CalculateDecrease(long amount, long spentDays, int indexMonth)
        {
            base.IndexOfThePossibleMonth = indexMonth;
            Amount = amount;
            SpentDays = spentDays;
        }

        public override int DaysOfCalculatedMonth(int month)
        => Consts.DAYSEACHMONTH.ElementAt(month);

        private long DecreaseDays(long amount, long days)
        => (amount > days) ?
            (amount - days) :
            (days - amount);

        public override long CalculateYear()
        => DecreaseDays(Amount, SpentDays) / 365;

        public override long DaysRemainingForTheCalculatedYear()
        { 
            var days = DecreaseDays(Amount, SpentDays) % 365;
            base.DaysRemaining = days;

            return days;
        }
    }
}