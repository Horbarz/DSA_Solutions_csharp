using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpFundamentals{

    public class sockMerchant { 

        public static int sockMer(int n, int[] ar){
            int counter = 0;
            var set = new HashSet<int>();
            for(int i=0; i<n; i++){
                int element = ar[i];
                if(set.Contains(element)){
                    set.Remove(element);
                    counter++;
                }else{
                    set.Add(element);
                }
            }
            return counter;
        }

    }

}