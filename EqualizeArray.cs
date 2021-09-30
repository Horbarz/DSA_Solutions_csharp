namespace csharpFundamentals
{
    public class EqualizeArray
    {

        // Problem Statement
        // Given an array of integers, determine the minimum number of elements to delete to leave only elements of equal value.

        public static int aim(int[] arr)
        {
            int n = arr.Length;
            int[] aux = new int[101];
            for (int i = 0; i < n; i++)
            {
                int index = arr[i];
                aux[index]++;
            }
            return (n - getMaxFreq(aux));
        }


        public static int getMaxFreq(int[] aux)
        {
            int maxCount = 0;
            foreach (var freq in aux)
            {
                if (freq > maxCount)
                {
                    maxCount = freq;
                }
            }
            return maxCount;
        }
    }
}


