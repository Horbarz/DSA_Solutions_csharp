using System;

namespace csharpFundamentals
{
    public class arrayPack
    {
        public static int arrayPacking(int[] a)
        {
            string total = "";
            string[] binArr = new string[a.Length];
            for (int i = a.Length - 1; i >= 0; i--)
            {
                binArr[i] = Convert.ToString(a[i], 2);
                if (binArr[i].Length < 8)
                {
                    int len = 8 - binArr[i].Length;
                    string x = new string('0', len);
                    binArr[i] = x + binArr[i];

                }
                total += binArr[i];

            }


            return Convert.ToInt32(total, 2);
        }

    }
}