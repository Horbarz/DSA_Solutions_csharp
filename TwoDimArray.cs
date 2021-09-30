using System;
using static System.Console;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace csharpFundamentals
{
    public class TwoDimArray
    {
        public static int hourglassSum(int[][] arr)
        {
            List<int> finalArr = new List<int>();
            int total = 0;
            int[] x_arr = new int[5];
            int count_i = 0;
            int len = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                List<int> arr_one = ArrSum(arr[i]);
                List<int> arr_two = ArrVals(arr[i + 1]);
                List<int> arr_three = ArrSum(arr[i + 2]);
                for (int x = 0; x < arr_one.Count; x++)
                {
                    finalArr.Add(arr_one[x] + arr_two[x] + arr_three[x]);
                }
                if (count_i == 3 && len != 0)
                {
                    len = len - 1;
                    i = i - 2;
                    count_i = 0;
                }

            }
            return finalArr.Max();
        }

        public static List<int> ArrSum(int[] arr)
        {
            List<int> newArr = new List<int>();
            int count = 0;
            int total = 0;
            int len = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];

                count++;
                if (count == 3 && len != 0)
                {
                    newArr.Add(total);
                    len = len - 1;
                    i = i - 2;
                    count = 0;
                    total = 0;
                }

            }
            newArr.Add(total);
            return newArr;
        }

        public static List<int> ArrVals(int[] arr)
        {
            List<int> newArr = new List<int>();
            for (int i = 1; i < 5; i++)
            {
                newArr.Add(arr[i]);
            }

            return newArr;
        }


    }
}