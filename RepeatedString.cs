using System;

namespace csharpFundamentals
{

    public class RepeatedString
    {

        public static long repeatedStr(string s, long n)
        {
            long final = 0;
            int len = s.Length;
            long main = n / len;
            long rem = n % len;
            int count = 0;
            foreach (var x in s)
            {
                if (x.Equals('a')) count++;
            }
            if (rem == 0)
            {
                final = (count * main);
            }
            else
            {
                int newcount = 0;
                string newStr = s.Substring(0, Convert.ToInt32(rem));
                foreach (var x in newStr)
                {
                    if (x.Equals('a')) newcount++;
                }
                final = (count * main) + newcount;
            }
            return final;



        }


    }

}