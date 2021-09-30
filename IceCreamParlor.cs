using System.Collections;

namespace csharpFundamentals
{
    public class IceCreamParlor
    {
        //4 --> 1324
        // public static int [] TwoSum(int m, int[]arr){
        //     var result = new int[2];
        //     for(int i=0;i<arr.Length;i++){
        //         for(int j=0;j<arr.Length;j++){
        //             if(arr[i]+arr[j]==m){
        //                 result[0] = i+1;
        //                 result[1] = i+2;
        //             }
        //         }
        //     }
        //     return result;
        // }

        ///Method two
        public static int[] TwoSum(int m, int[] arr)
        {
            int[] res = new int[2];
            Hashtable uHash = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                int comp = m - arr[i];
                if (uHash.ContainsKey(comp))
                {
                    res[0] = (int)uHash[comp];
                    res[1] = i;
                }
                else
                {
                    uHash.Add(arr[i], i);
                }


            }
            return res;


        }


    }
}