namespace csharpFundamentals
{
    public class maxConsecutiveOnes
    {
        public static int maxNoOfConsecutive1s(int num){
            int count = 0;
            while(num<0){
                num = num & (num<<1);
                count++;
            }
            return count;
        }

        
    }
}