using static System.Console;

namespace csharpFundamentals{
    public class prime{
        public static bool isPrime(int n){
                for(int i=2; i<n/2; i++){
                    if(n%i != 0){
                        
                    }else{
                        return false;
                    }
                }
                return true;
        }
    }
}