namespace csharpFundamentals
{
    public class FIndDigits
    {
        public static int isDivisor(int x){
            int count = 0;
            int num = x;
            while(x>0){
                int r = x%10;
                if(num%r==0&&r!=0){
                    count++;
                }
                x/=10;
            }
            return count;
        }
    }
}