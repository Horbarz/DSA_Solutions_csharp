using static System.Console;
using System.Linq;
using System;

namespace csharpFundamentals
{
    public class MarksAndToys
    {
        public static int maximumToys(int[] prices, int k)
        {
            int sum = 0;
            int count = 0;
            Array.Sort(prices);
            for (int i = 0; i < prices.Length; i++)
            {
                if (i < k)
                {
                    sum += prices[i];
                    if (sum <= k)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}