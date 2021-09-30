using System;
using System.Linq;

namespace csharpFundamentals
{
    public class ArrayManipulation
    {
        public static long SmartArray(int n, int[,] queries)
        {
            //create a new array to store newly evaluated array after manipulation
            //the array has extra length of 2 bcos of the algorithm used
            long[] newArr = new long[n + 2];
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int a = queries[i, 0];
                int b = queries[i, 1];
                int k = queries[i, 2];
                newArr[a] += k;
                newArr[b + 1] -= k;
            }
            //int maxVal = Convert.ToInt32(newArr.Max());
            newArr = prefixSum(newArr);
            return newArr.Max();
        }

        public static long[] prefixSum(long[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i] + arr[i - 1];
            }
            return arr;
        }
    }

}