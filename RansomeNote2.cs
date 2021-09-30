using System;
using System.Collections;
namespace csharpFundamentals
{
    public class RansomeNote2
    {
        public static void checkMag(string[] magazine, string[] note)
        {
            Hashtable magHash = new Hashtable();
            foreach (string word in magazine)
            {
                if (magHash.ContainsKey(word))
                {
                    int count = (int)magHash[word];
                    Console.WriteLine(count);
                    count++;
                    magHash[word] = count;
                }
                else
                {
                    magHash.Add(word, 1);
                }
            }



            foreach (string word in note)
            {
                if (magHash.ContainsKey(word))
                {
                    int count = (int)magHash[word];
                    //Console.WriteLine($"{word} - {count}");
                    if (count <= 0)
                    {
                        Console.WriteLine(count);
                        Console.WriteLine("No");
                        return;
                    }
                    count--;
                    magHash[word] = count;
                    //Console.WriteLine(count);
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            foreach (DictionaryEntry e in magHash)
            {
                Console.WriteLine($"Key: {e.Key} | Value: {e.Value}");
            }

            //Console.WriteLine("Yes");

        }
    }
}