using System;
using static System.Console;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace csharpFundamentals
{
    //Given two strings,  and , that may or may not be of the same length, 
    //determine the minimum number of character deletions required to make and  
    //anagrams. Any characters can be deleted from either of the strings. E.g a = 'cde' b='dcf' ans = 4
    public class MakingAnagrams
    {
        public static int makeAnagram(string a, string b)
        {
            //Method 1
            int j = 0;
            string less = "";
            string main = "";
            int lenA = a.Length;
            int lenB = b.Length;
            int totalLen = lenA + lenB;
            int temp = totalLen;
            if (lenA <= lenB)
            {
                less = a;
                main = b;
            }
            else
            {
                main = a;
                less = b;
            }
            List<char> mainChar = new List<char>(main.Length);
            List<char> lessChar = new List<char>(less.Length);
            mainChar = main.ToList();
            lessChar = less.ToList();

            for (int i = 0; i < less.Length; i++)
            {
                if (mainChar.Contains(lessChar[i]))
                {
                    totalLen -= 2;
                    mainChar.Remove(lessChar[i]);
                }
            }
            if (totalLen == temp)
            {
                return 0;
            }

            return totalLen;

            //Method 2 using Hash Table

            // Hashtable count = new Hashtable();
            // //loop through each char and add to the array
            // foreach (char i in a)
            // {
            //     int ct = count.ContainsKey(i) ? (int)count[i] : 0;
            //     count[i] = ct + i;
            // }
            // foreach (char j in b)
            // {
            //     int ct = count.ContainsKey(j) ? (int)count[j] : 0;
            //     count[j] = ct - 1;
            // }

            // List<int> values = count.Values.Cast<int>().ToList();
            // int total = 0;
            // foreach (int x in values)
            // {
            //     //WriteLine(x);
            //     total += Math.Abs(x);
            // }

            // foreach (DictionaryEntry e in count)
            // {
            //     Console.WriteLine($"Key: {e.Key} | Value: {e.Value}");
            // }

            // return total;

        //     if(a.Length>b.Length){
        //     return getLength(b,a);
        // }else{
        //     return getLength(a,b);
        // }

        //  int count = 0;
        // List<char> xString = new List<char>();
        // //xString = x.ToList();
        // List<char> yString = new List<char>(y.Length);
        // yString = y.ToList();
        // foreach(char i in x){
        //     if(y.Contains(i)){
        //         yString.Remove(i);
        //     }else{
        //         xString.Add(i);
        //     }
        // }
        // return yString.Count + xString.Count;
        }

    }
}