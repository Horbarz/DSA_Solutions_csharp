namespace csharpFundamentals
{
    public class Kangaroos
    {
        public static string getToSameLocation(int x1, int v1, int x2, int v2){
            if(v1>v2){
                int jumps = (x2-x1)%(v1-v2);
                if(jumps == 0){
                    return "YES";

                }else{
                    return "NO";
                }
            }
            return "";


        }
    }
}