using System;
using System.Linq;

namespace csharpFundamentals
{
    public class MaxString
    {
        public static string getMaxString(string str)
        {
            var ans = str.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            return ans.ToString();
        }
    }
}