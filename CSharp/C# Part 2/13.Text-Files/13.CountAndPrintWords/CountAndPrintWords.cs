/*Write a program that reads a list of 
 * words from a file words.txt and finds
 * how many times each of the words is
 * contained in another file test.txt. 
 * The result should be written in the 
 * file result.txt and the words should 
 * be sorted by the number of their 
 * occurrences in descending order. 
 * Handle all possible exceptions in your methods.
*/

using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class CountAndPrintWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines(@"../../words.txt");
            int[] matches = new int[words.Length];

            using (StreamReader reader = new StreamReader(@"../../test.txt"))
            {
                string line = reader.ReadToEnd();

                for (int i = 0; i < words.Length; i++)
                {
                    matches[i] = Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                }
            }

            Array.Sort(matches, words);

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0} {1}", words[i], matches[i]);
                }
            }

            Console.WriteLine("result.txt created");
        }
        catch (Exception exc)
        {
            Console.WriteLine("Something went wrong!" + exc.Message);
        }
    }
}
