using System.Collections;
using System;

namespace csharpFundamentals
{
    public class IsUnique
    {
        public static bool isStringUnique(string s)
        {
            if (s.Length > 128) return false;
            bool[] char_state = new bool[128];
            for (int i = 0; i < s.Length; i++)
            {
                int val = s[i];
                Console.WriteLine(val);
                if (char_state[val])
                {
                    return false;
                }
                char_state[val] = true;
            }
            //     //ababcc
            //     Hashtable pHash = new Hashtable();
            //     for (int i = 0; i < s.Length; i++)
            //     {
            //         char current = s[i];
            //         if (pHash.ContainsKey(current))
            //         {
            //             return false;
            //         }
            //         pHash[current] = i;
            //     }

            return true;
        }


    }
}