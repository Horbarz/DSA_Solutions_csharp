using static System.Console;

namespace csharpFundamentals
{
    public class BubbleSort
    {
        public static void countSwaps(int[] a)
        {
            int swapCounter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < (a.Length - 1); j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);
                        swapCounter++;
                    }
                }
            }
            WriteLine("Array is sorted in " + swapCounter.ToString() + " swaps.");
            WriteLine("First Element: " + a[0].ToString());
            WriteLine("Last Element: " + a[a.Length - 1].ToString());

        }

        public static int[] swap(int[] a, int i, int j)
        {
            int temp = a[j];
            a[j] = a[i];
            a[i] = temp;
            return a;
        }
    }
}