using System;
using System.Linq;
namespace csharpFundamentals
{

    public class LinqTutoriaL
    {

        //COUNT occurences of a word in linq
        public static void findWord(string text, string searchText)
        {
            //convert string into an array of words
            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            //create the query
            var matchQuery = from word in source where word.ToLowerInvariant() == searchText.ToLowerInvariant() select word;

            int wordCount = matchQuery.Count();

            Console.WriteLine("{0} occurences of the search text \"{1}\" was found", wordCount, searchText);

        }

        public static void findSentences(string text, string[] searchWords)
        {
            //break down the whole text into sentences
            string[] sentences = text.Split(new char[] { '.', '?', '!' });

            //linq query to find sentences that contain all the words in the searchWords
            var sentenceQuery = from sentence in sentences
                                let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(searchWords).Count() == searchWords.Count()
                                select sentence;

            foreach (string str in sentenceQuery)
            {
                Console.WriteLine(str);
            }


        }


    }

}

