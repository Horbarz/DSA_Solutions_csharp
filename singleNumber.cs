using System;

namespace csharpFundamentals{
    public class singleNumber{
        public static int single(int[]x){
            int singleNum = 0;
            Array.Sort(x);
            if(x.Length == 1){
                singleNum = x[0];
            }else{
                for(int i=0;i<x.Length-1;){
                if(x[i] != x[i+1]){
                    singleNum = x[i];
                    break;
                }else{
                    i = i+2;
                    if(i>=(x.Length-1)){
                        singleNum = x[x.Length - 1];
                    }
                }
            }
            }
            
            return singleNum;
        }
    }
}