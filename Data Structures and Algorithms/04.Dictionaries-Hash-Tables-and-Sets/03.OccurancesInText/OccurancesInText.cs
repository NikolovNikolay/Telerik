/*Write a program that counts how many times each word from
 * given text file words.txt appears in it. The character 
 * casing differences should be ignored. The result words 
 * should be ordered by their number of occurrences in the 
 * text.*/

namespace OccurancesInText
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class OccurancesInText
    {
        static void Main()
        {
            var words = ValidateInput();
            IDictionary<string, int> occurances = new SortedDictionary<string, int>();
            GetOccurances(occurances, words);
            PrintOccurances(occurances);
        }

        private static void PrintOccurances(IDictionary<string, int> occurances)
        {
            foreach (var item in occurances)
            {
                Console.WriteLine("\"{0}\" -> {1}", item.Key, item.Value);
            }
        }

        private static string[] ValidateInput()
        {
            string text = string.Empty;

            using (StreamReader sr = new StreamReader(@"input.txt"))
            {
                text = sr.ReadToEnd();
                text = text.ToLower();
            }
            var partialText = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            return partialText;
        }

        private static void GetOccurances(IDictionary<string,int> dict, string[] words)
        {
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
        }
    }
}
