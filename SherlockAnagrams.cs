using System;
using System.Collections;
namespace csharpFundamentals
{

    public class SherlockAnagram
    {

        public static int sherAna(string s)
        {
            Hashtable sHash = new Hashtable();
            int ana = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    char[] newArr = s.Substring(i, j).ToCharArray();
                    Array.Sort(newArr);
                    string newStr = new string(newArr);

                    if (sHash.ContainsKey(newStr))
                    {
                        int value = (int)sHash[newStr];
                        value++;
                        sHash[newStr] = value;
                    }
                    else
                    {
                        sHash.Add(newStr, 1);
                    }
                }
            }

            foreach (string u in sHash.Keys)
            {
                int val = (int)sHash[u];
                ana += (val * (val - 1)) / 2;
            }

            return ana;
        }

    }
}