using System;
namespace csharpFundamentals{
    public class prothNumber{
        public static bool isProthPrime(int n){
            int N = n-1;
            for(int k=1;k<(N/k);k=k+2){
                if((N%k==0) && isPowTwo(N/k)){
                    if(isPrime(n))
                        return true;
                }
            }
            return false;
        }

        static bool isPowTwo(int n){
            if(n!=0){
                return (int)(Math.Ceiling((Math.Log(n)/Math.Log(2))))
                    == (int)(Math.Floor((Math.Log(n)/Math.Log(2))));
            }else{
                return false;
            }
        }
        static bool isPrime(int n){
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