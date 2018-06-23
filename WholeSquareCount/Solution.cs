using System;
using System.Collections.Generic;

namespace WholeSquareCount
{
    public class Solution
    {
        public int[] WholeSquareCount(int a, int b)
        {
            var result = new List<int>();
            // Only complex numbers can have negative squares
            if (!(a < 0 && b < 0))
            {
                var start = ZeroIfNegative(a);
                var end = ZeroIfNegative(b);
                for (int i = start; i <= end; i++)
                {
                    var root = Math.Sqrt(i);
                    if (root % 1 == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result.ToArray();
        }

        private int ZeroIfNegative(int value)
        {
            return value > 0 ? value : 0;
        }
    }
}
