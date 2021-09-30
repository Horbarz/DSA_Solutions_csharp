using System;
using System.Linq;
namespace csharpFundamentals
{

    public class RansomeNote
    {
        public static void checkMagazine(string[] magazine, string[] note)
        {
            bool checker = false;
            foreach (string word in note)
            {
                if (!verifyword(word, magazine))
                {
                    checker = false;
                    break;
                }
                else
                {
                    magazine = magazine.Where(x => x != word).ToArray();
                    checker = true;
                }

            }
            if (checker)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }

        public static bool verifyword(string word, string[] words)
        {
            string newWords = string.Join(" ", words);
            if (newWords.Contains(word))
            {
                return true;
            }
            // foreach (string x in words)
            // {
            //     if (x.Equals(word))
            //     {
            //         return true;
            //     }
            // }
            return false;

        }
    }
}