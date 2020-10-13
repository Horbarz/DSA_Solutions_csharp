using System;
using System.Collections.Generic;

namespace csharpFundamentals{
    public class stringReversal{
        public static char []rev(char []x, int count){
           
            int len = x.Length;
            var first = x[count-1];
            x[count-1] = x[len-count];
            x[len-count] = first;
            if(count<=(len/2)){   
                rev(x,count+1);
            }
            return x;
        }
    }

}