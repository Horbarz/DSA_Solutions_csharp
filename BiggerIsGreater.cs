using System;

namespace csharpFundamentals
{
    public class BiggerIsGreater
    {
        public static string bIG(string w){
            int n = w.Length;
            char [] chrArray = w.ToCharArray();
            int endIndex = 0;
            for(endIndex=n-1; endIndex>0;endIndex--){
                if(chrArray[endIndex]>chrArray[endIndex-1]){
                    break;
                }
            }

            if(endIndex==0){
                return "No answer";
            }else{
                int firstSmallChar = endIndex-1;
                int nextSmallChar = endIndex;
                for(int startIndex=endIndex+1; startIndex<n;startIndex++){
                    if(chrArray[startIndex]>chrArray[firstSmallChar] 
                    && chrArray[startIndex]<chrArray[endIndex]){
                        nextSmallChar = startIndex;
                    }
                }
                swap(chrArray,firstSmallChar,nextSmallChar);

                Array.Sort(chrArray,endIndex,n-endIndex);
            }
            return new string(chrArray);
        }

        private static void swap(char[] chrArray, int firstSmallChar, int nextSmallChar)
        {
            char tmp = chrArray[nextSmallChar];
            char temp = chrArray[firstSmallChar];
            chrArray[nextSmallChar] = temp;
            chrArray[firstSmallChar] = tmp;

        }
    }
}