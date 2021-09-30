using System;

namespace csharpFundamentals
{
    public class modifyAlpha
    {
        public static String solution(String S)
        {
            int[] occurrences = new int[26];
            foreach (char ch in S)
            {
                occurrences[(int)ch - 'a']++;
            }

            char best_char = 'a';
            int best_res = 0;

            for (int i = 1; i < 26; i++)
            {
                if (occurrences[i] > best_res)
                {
                    best_char = (char)('a' + i);
                    best_res = occurrences[i];
                }
            }

            return best_char.ToString();
        }
    }
}