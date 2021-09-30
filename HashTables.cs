using System;
using System.Collections;

namespace csharpFundamentals
{
    public class HashTables
    {
        public static void HashTest()
        {
            Hashtable userHash = new Hashtable();
            //Add to the hashtable
            for (int i = 0; i < 10; i++)
            {
                userHash.Add(i, "user" + i);
            }

            //removing from the hash
            if (userHash.ContainsKey(0))
            {
                userHash.Remove(0);
            }

            //Updating the value
            if (userHash.ContainsKey(1))
            {
                userHash[1] = "Horbarz";

            }

            // foreach (DictionaryEntry e in userHash)
            // {
            //     Console.WriteLine($"Key: {e.Key} | Value: {e.Value}");
            // }

            foreach (int x in userHash.Keys)
            {
                var val = userHash[x];
                Console.WriteLine(val);
            }
        }
    }
}