using System;
using System.Linq;

namespace csharpFundamentals
{
    public class sample
    {
        public static int getMinimumCost(int k, int[] c)
        {
            int ans = 0;
            int j = 0;
            if (k >= c.Length)
            {
                return c.Sum();
            }
            else if (k == 1)
            {
                int totalInitials = 0;
                for (int i = c.Length - 1; i >= 0; i--, j++)
                {
                    totalInitials += ((j + 1) * c[i]);
                }
            }
            else if (k > c.Length / 2)
            {
                int totalInitials = 0;
                for (int i = c.Length - 1; i >= 0; i--)
                {
                    if (i > (c.Length - 1 - k))
                    {
                        totalInitials += c[i];
                        //Console.WriteLine(i);
                    }
                    else
                    {
                        totalInitials += (c[i] * 2);
                        Console.WriteLine(i);
                    }

                }
                ans = totalInitials;
                //Console.WriteLine(totalInitials);
            }
            else
            {
                //return 0;
                int totalInitials = 0;
                for (int i = c.Length - 1; i >= 0; i--)
                {
                    if (i > (c.Length - 1 - k))
                    {
                        totalInitials += c[i];
                        //Console.WriteLine(i);
                    }
                    else
                    {
                        totalInitials += (c[i] * 2);
                        Console.WriteLine(i);
                    }

                }
                ans = totalInitials;
            }
            return ans;
        }
    }
}