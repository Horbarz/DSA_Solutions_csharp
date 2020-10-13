using System;

namespace csharpFundamentals{

    public class CountingValley{
        public static int CV(string s){
            int len = s.Length;
            int valleyCount = 0 , altitude = 0;
            for(int i=1; i<len; i++){
                Char ch = s[i];
                if(ch=='U'){
                    altitude++;
                    if(altitude == 0){
                        valleyCount++;
                    }
                }else{
                    altitude--;
                }

            }
            return valleyCount;
        }
    }
}