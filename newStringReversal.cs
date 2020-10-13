using System;
using System.Collections.Generic;

namespace csharpFundamentals{
    public class newStringReversal{
        public static char []rev(char []x){
            int count = 0;
            int len = x.Length;
            var first = x[count];
            x[count] = x[len-count-1];
            x[len-count-1] = first;
            if(count<=(len/2)){  
                count++; 
                rev(x);
            }
            return x;
        }
    }

}