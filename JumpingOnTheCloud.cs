// Problem:- Some of the cloud are thnderhead while some are cumulus, she can jump on the cumulus 
// having a nuber thars is equal to thre number on the current cloud plus 1 or 2.
//Determine the min jumps it would take to jump from thr starting positin to the last clotud
//An array of 0 or 1 s given 1 for safe 0 for avoided


using System;

namespace csharpFundamentals{
    public sealed class Circle {
        private double radius;
        
        public double Calculate(Func<double, double> op) {
            return op(radius);
         }
    }
    public class JumpingOnTheCloud{
        // public static int JOTC(int[]x){
        //     var len = x.Length;
        //     var count = -1;
        //     for(int i = 0; i<len;){
        //         if((i+2)<len && x[i+2]==0){
        //             i+=2;
        //         }else
        //         {
        //             i++;
        //         }
        //         count ++;
        //     }
        //     return count;
        // }
    //A cleaner code
        public static int JOTC(int[]x){
            var len = x.Length;
            var count = -1;
            for(int i = 0; i<len;i++,count++){
                if((i+2)<len && x[i+2]==0){
                    //This omly executes if it mets the requirements
                    i++;
                }
                //This statement would always execute, it can always be made cleaner tho
                // i++;
                // count ++;
            }
            return count;
        }

        public static int AddNo(int x, int y){

            while(y!=0){

                int carry = x&y;

                x = x^y;
                y = carry<<1;
            }
            return x;
        }

        

        public static void adjustDate(){

            Console.Write("Enter the date in the format Month/Day/Year. ");
            var inputValue = Console.ReadLine();
            Console.WriteLine(DateTime.Parse(inputValue).ToString("yyyy/MM/dd"));
        }

        public static int[] arrayDecreasing(int[]x){
            int [] y = x;
            Array.Reverse(y);
            return y; 
        }

        //

        public static bool checkIfConsecutive(int[]x){
            int count = 0;
            for(int i=0;i<x.Length-1;i++){
                if(x[i+1]-x[i] == 1){
                    count++;
                    if(count==5){
                        return true;
                    }
                }
            }

            return false;
        }

        


    }
}