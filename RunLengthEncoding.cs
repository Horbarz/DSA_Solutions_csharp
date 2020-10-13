using System;
using System.Text;

namespace csharpFundamentals
{
    public class RunLengthEncoding
    {
        //"WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWB"  ->  "12WB12W3B24WB"
        public static string Encode(string input){
            var count = 1;
            var output = new StringBuilder();
            char prev = input[0];
            foreach(var c in input.Substring(1)){
                if(c!=prev){
                    append(output, count, prev);
                    count = 0;
                }
                count++;
                prev = c;
            }
            append(output,count,prev);
            return output.ToString();
        }

        private static void append(StringBuilder output, int count, char c)
        {
            if(count==1){
                output.Append(c);
            }else{
                output.Append($"{count}{c}");
            }
            
        }

        public static string Decode(string input){
            var digit = string.Empty;
            var result = new StringBuilder();
            foreach(var c in input){
                if(char.IsDigit(c)){
                    digit+=c;
                }else{
                    if(digit==string.Empty){
                        result.Append(c);
                    }else{
                        result.Append(new string(c,int.Parse(digit)));
                    }
                    digit = string.Empty;

                }
            }
            return result.ToString();


        }
    }
}