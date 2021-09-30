using System.Collections;
using System.Linq;
using System;

namespace csharpFundamentals
{
    public class smallestInt
    {
        public static int smallInt(int[] a)
        {
            int val = 0;
            var u_arr = a.Distinct().ToArray();
            Hashtable uHash = new Hashtable();
            int max_val = u_arr.Max();
            int min_val = u_arr.Min();
            if (max_val < 0)
            {
                return 1;
            }
            for (int i = 0; i < u_arr.Length; i++)
            {
                //Console.WriteLine(u_arr[i]);
                uHash.Add(u_arr[i], "1");
            }
            for (int i = 0; i < max_val; i++)
            {
                if (!(uHash.ContainsKey(i)))
                {
                    val = i;

                }
                else
                {
                    if (i == max_val - 1)
                    {
                        val = max_val + 1;
                    }
                }
            }

            return val;
        }
    }
}