using System;
using System.Collections;
namespace csharpFundamentals
{
    public class TwoString
    {

        public static void twoStrings(string s1, string s2)
        {
            Hashtable s1Hash = new Hashtable();
            Hashtable s2Hash = new Hashtable();
            int lenS1 = s1.Length;
            int lenS2 = s2.Length;
            int count = 0;

            if (lenS1 > lenS2)
            {
                foreach (char a in s1)
                {
                    s1Hash.Add(a, 1);
                }
                foreach (char a in s2)
                {
                    if (s1Hash.ContainsKey(a))
                    {
                        count++;
                    }
                }
            }
            else
            {

                foreach (char a in s2)
                {
                    s2Hash.Add(a, 1);
                }

                foreach (char a in s1)
                {
                    if (s2Hash.ContainsKey(a))
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }



        }


    }
}