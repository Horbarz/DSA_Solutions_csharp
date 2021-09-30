using System;

namespace csharpFundamentals

{
    public class graph
    {
        public static bool sol(int N, int[] A, int[] B)
        {
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > N || B[i] > N)
                {
                    continue;
                }
                int val = A[i] - B[i];
                Console.WriteLine(val);
                if (val == 1 || val == -1)
                {
                    count++;
                }
            }
            if (count == N - 1)
            {
                return true;
            }
            return false;
        }
    }
}