using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace csharpFundamentals
{
    public class HackerRank
    {
        static void main (string [] args)
        {
              
        }

        public static int[] removeDup(int [] a){
            HashSet<int> set = new HashSet<int>();
            foreach(var item in a ){
                set.Add(item);
            }
            int len = set.Count;
            int[] result = new int[len];
            int i = 0;
            foreach(var item in set){
                result[i++] = item;
            }
            return result;
        }
        public static int getNumberLessDanKey(int[]distinctA, int key){
            int low = 0;
            int high = distinctA.Length-1;
            int count = -1;

            while(low<high){
                int mid = (high+low)/2;
                if(distinctA[mid] <= key){
                    count = key;
                    low = mid + 1;
                }
                else{
                    high = mid-1;
                }
            }
            return count;
        }

        public static int getTripleSum(int[] A, int[] B, int[]C){
            var distinctA = removeDup(A);
            var distinctB = removeDup(B);
            var distinctC = removeDup(C);

            int totalTriple = 0;

            Array.Sort(distinctA);
            Array.Sort(distinctB);
            Array.Sort(distinctC);

            foreach(var item in distinctB){
                int c = (getNumberLessDanKey(distinctA,item) * getNumberLessDanKey(distinctC,item));
                totalTriple+=c;
            }
            return totalTriple;           
        }

        public static bool isPalindrome(string x){
            x = x.ToLower();
            var len = x.Length;
            var midLen = x.Length/2;
            for(int i=0;i<midLen;i++,len--){
                if(x[i]!=x[len-1]){
                    return false;
                }
            }
            return true;
        }

        //TestCase: bbabbbb => returns index of the char that makes a given string palindrom
        public static int palindromIndex(string x){
            int palindromIndex = -1;
            x = x.ToLower();
            var len = x.Length;
            for(int i=0;i<len;i++){
                if(x[i] != x[len-i-1]){
                    if(i+1<len){
                        bool isRemainingPalind = isPalindrome(x.Substring((i),(len-i)));
                        if(isRemainingPalind){return i;}    
                        return len-i-1;   
                    }
                }
            }
            return palindromIndex;
        }

        public static int newPalindromIndex(string x){
            int palindromIndex = -1;
            x = x.ToLower();
            var len = x.Length;
            if(isPalindrome(x)){
                return palindromIndex;
            }else{
                for(int i=0; i<len;i++){
                    if(i+1<len){
                        var newStr = x.Substring((i+1),(len-i-1));
                        if(isPalindrome(newStr)){
                            return i;
                        }
                    }
                }
            }
            return palindromIndex;

        }

        public static String replaceCharAt(String s, int pos, char c) {
            return s.Substring(0,pos) + c + s.Substring(pos+1);
        }

        // public static int palindIndex(string x){
        //         var newstr = x.ToCharArray();
        //         int palindIndex = -1;
        //         x = x.ToLower();
        //         var len = x.Length;
        //         if(isPalindrome(x))
        //             return palindIndex;
        //         for(int i=0;i<len;i++){
        //             if(i+1<len){
        //                 var newx = x.Replace(newstr[i],' ');
        //                 newx = String.Join("",newx);
        //                 if(isPalindrome(newx)){
        //                     return i;
        //                 }
        //             }
        //         }
        //         return palindIndex;    
        //     }
        

        //Example: 99100101 must be separable into 99,100,101 such that 100-99=1

        public static bool isBeautifulNo(string x){
            var midLen = x.Length/2;
            for(int i=1; i<=midLen;i++){
                var subStr = x.Substring(0,i);
                long subInt = long.Parse(subStr);
                var validStr = subStr;
                while(validStr.Length<x.Length){
                    validStr += (++subInt).ToString();
                }
                if(validStr.Equals(x)){
                    return true;
                }
            }

            return false;
        }
    //Array manipulattion
       public static int ArrayManip(int n, int input){


           return -1;
       }

       //The quick brown fox jumps over the lazy dog

       public static bool checkPanagram(string x){
            x = x.ToLower();
            //var alpha = "abcdefghijklmnopqrstuvwxyz";

            return x.Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count()==26;

        }

        //Write a method that takes an integer and return a Fibonacci n
        //0,1,1,2,3,4,5,6
        public static int Fib(int n){
            if(n == 0 || n == 1) return n;
            return Fib(n-2)+Fib(n-1);
        } 

        public static int makingChange(int amount, int[] denom){

            return -1;
        }

        public static int totalEven(int[] x){
            var total = 0;
            foreach(var i in x){
                if(i%2==0){
                    total+=i;
                }
            }
            return total;
        }

        //using linq queries
        public static int totalAllEven(int [] x){
            return x.Where(i => i%2==0).Sum(i => (int)i);
        }

        public static int hourGlassSum(int[][]arr){
            int rows = arr.Length;
            int column = arr[0].Length;
            int maxHourGlass = int.MinValue;
            for(int i=0;i<rows-2;i++){
                for(int j=0;j<column-2;j++){
                    int current_hourglass_sum = arr[i][j]+arr[i][j+1]+arr[i][j+2]+arr[i+1][j+1]+arr[i+2][j]
                    +arr[i+2][j+1]+arr[i+2][j+2];
                    maxHourGlass = Math.Max(current_hourglass_sum,maxHourGlass);
                }
            }

            return maxHourGlass;

        }
        //if d=2 1235--> 3512
        public static int[] rotLeft(int []a, int d){
            int n = a.Length;

            //Approach one
            // int[] rotated = new int[n];
            // Array.Copy(a,d,rotated,0,n-d);
            // Array.Copy(a,0,rotated,n-d,d);

            // return rotated;

            //Approach two
            int[] rotated_arr = new int[n];
            int i =0;
            int rotated_index = d;
            while(rotated_index<n){
                rotated_arr[i] = a[rotated_index];
                i++;
                rotated_index++;
            }

            rotated_index = 0;
            while(rotated_index<d){
                rotated_arr[i] = a[rotated_index];
                i++;
                rotated_index++;
            }
            return rotated_arr;
        }

        //13524
        //42135
        public static int minimumSwaps(int[]arr){
            int n = arr.Length;
            int swaps = 0;
            var result = new Boolean[n];
            for(int i=0;i<n;i++){
                int j=i, cycle=0;
                while(!result[j]){
                    result[j] = true;
                    j = arr[j] - 1;
                    cycle++;
                    
                }
                if(cycle!=0){
                    swaps+=cycle-1;
                }
            }
            return swaps;
            
        }
    }
}