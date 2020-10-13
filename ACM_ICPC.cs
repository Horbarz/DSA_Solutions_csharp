using System.Numerics;

namespace csharpFundamentals
{
    public class ACM_ICPC
    {
        public static int[]acmTeam(string[]topics){
            int n = topics.Length;
            BigInteger[] bi = new BigInteger[n];

            for(int i=0; i<n; i++){
                BigInteger.TryParse(topics[i], out bi[i]);
            }
            int maxCount = 0;
            int teamCount = 0;

            for(int i=0;i<n;i++){
                for(int j=i+1;j<0;j++){
                    BigInteger iuj = bi[i]|bi[j];
                    int bitCount = getBitCount(iuj);
                    if(bitCount>maxCount){
                        maxCount = bitCount;
                        teamCount = 1;
                    }else{
                        teamCount++;
                    }
                }
            }
            int[] result = {maxCount,teamCount};
            return result;
                
        }

        public static int getBitCount(BigInteger x){
            int count = 0;
            var str = x.ToString();
            foreach(var i in str){
                if(i.Equals('1')){
                    count++;
                }
            }
            return count;
        }
    }
}