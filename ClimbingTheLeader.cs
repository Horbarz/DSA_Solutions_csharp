using System;
using static System.Console;

namespace csharpFundamentals
{
    public class ClimbingTheLeader
    {
        public static int[]ctlb(int[]scores,int[]alice){
            int n = scores.Length;
            int m = alice.Length;
            int [] rank = new int[n];
            int [] res = new int[m];
            rank[0] = 1;

            for(int i=1; i<n;i++){
                if(scores[i] == scores[i-1]){
                    rank[i] = rank[i-1];
                }else{
                    rank[i] = rank[i-1]+1;
                }
            }

            for(int i =0;i<m;i++){
                int aliceScore = alice[i];
                if(aliceScore>scores[0]){
                    res[i]= 1;
                }
                else if(aliceScore<scores[n-1]){
                    res[i] = rank[n-1]+1;
                }
                else{
                    int index = binarySearch(scores, aliceScore);
                    // Write("Index: ");
                    // WriteLine(index);
                    res[i] = rank[index];
                }
            }

            return res;
        }

        private static int binarySearch(int[] scores, int aliceScore)
        {
            int n = scores.Length;
            int lo = 0;
            int hi = n-1;
            while(lo<=hi){
                int mid = lo+(hi-lo)/2;
                if(scores[mid] == aliceScore){
                    return mid;
                }
                else if(scores[mid]<aliceScore && aliceScore<scores[mid-1]){
                    return mid;
                }
                else if(scores[mid]>aliceScore && aliceScore>scores[mid-1]){
                    return mid+1;
                }
                else if(scores[mid]>aliceScore){
                    lo = mid+1;
                }
                else if(scores[mid]<aliceScore){
                    hi = mid-1;
                }
                

            }
            return -1;
        }
    }
}