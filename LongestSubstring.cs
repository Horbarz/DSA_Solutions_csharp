using System;
using System.Collections;
using System.Collections.Generic;

namespace csharpFundamentals
{
    public class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            //abcabcbb
            int ans = 0;
            int temp = 0;
            Hashtable sHash = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (sHash.ContainsKey(current))
                {
                    temp = Math.Max(temp, (int)sHash[current] + 1);
                }
                //Add digit
                sHash[current] = i;
                ans = Math.Max(ans, i - temp + 1);

            }
            return ans;

            // int max = 0;
            // int windowStart = 0;
            // Dictionary<Char, int> data = new Dictionary<Char, int>();
            // for (int i = 0; i < s.Length; i++)
            // {
            //     Char current = s[i];

            //     if (data.ContainsKey(current))
            //     {
            //         windowStart = Math.Max(windowStart, data[current] + 1);
            //     }
            //     data[current] = i;
            //     //data.Add(current, i);
            //     //Console.WriteLine(data[current]);
            //     max = Math.Max(max, i - windowStart + 1);
            // }
            // return max;
        }
    }
}