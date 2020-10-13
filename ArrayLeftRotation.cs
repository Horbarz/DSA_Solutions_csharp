namespace csharpFundamentals
{
    public class ArrayLeftRotation
    {
        public static int[] alr(int[]a, int d){
            int n = a.Length;
            int[]rotArray = new int[n];
            for(int oldIndex=0; oldIndex<n;oldIndex++){
                int newIndex = (oldIndex+(n-d))%n;
                rotArray[newIndex] = a[oldIndex];
            }
            return rotArray;
        }
    }
}