using System;
using System.Collections.Generic;
using System.Linq;

namespace DateCalculator.Models.Extensions
{
    public static class ArrayExtension
    {
        public static int FindIndexRange(this List<int> array, long item)
        {
            var result = array.AsQueryable()
            .Select((x, index) => new
            {
                Index = index,
                Value = x,
                Diff = Math.Abs(x - item)
            })
            .OrderBy(x => x.Diff)
            .First()
            .Index;

            return result;
        }

        public static int FindValue(this List<int> array, int index)
        {
            var result = array.Select((x, i) => new
            {
                Index = i,
                Value = x
            }).FirstOrDefault(x => x.Index.Equals(index)).Value;

            return result;
        }
    }
}
