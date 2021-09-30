using System;
using static System.Console;
namespace csharpFundamentals{
    public class NewYearChaos{
        public static void minimumBribes(int[] q) {
            int swapCount = 0;
            //We need to get the min ways we can swap these array to arrive at a sorted array, not swaping a number more than twice
            //S1. loop thorough the array starting from behind, check if it has been swaped once or twice, then try to wap back
            for(int i = q.Length - 1; i>0; i--){
                //check if current digit @ ith position is not the expected one to be there
                if(q[i] != (i+1))
                {
                    //check if the current digit has been swaped once
                    if((i-1)>=0 && q[i-1]==(i+1)){
                        swapCount++;
                        swap(q,(i-1),i);
                    }
                    //check if the current digit has been swaped twice
                    else if((i-2)>=0 && q[i-2] == (i+1)){
                        swapCount += 2;
                        swap(q, (i-2),(i-1));
                        swap(q, (i-1), i);
                    }
                    //check if the current digit has been swaped more than twice
                    else{
                        WriteLine("Too Chaotic");
                        return;
                    }
                }
            }

            WriteLine(swapCount);

        }   

        public static void swap(int[] ar,int a, int b){
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }
    }
}