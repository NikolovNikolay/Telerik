/*Write a program that removes from a
 * text file all words listed in given 
 * another text file. Handle all possible
 * exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class RemoveWordsListed
{
    static void Main()
    {
        try
        {
            string text = "";
            using (StreamReader reader = new StreamReader(@"../../text.txt"))
            {
                text = reader.ReadToEnd();
            }

            var wordsToExclude = AddExcludeWords();

            text = ExcludeWordsFromText(text, wordsToExclude);
            Console.WriteLine(text);

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                writer.WriteLine(text);
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine("Something went wrong!" + exc.Message);
        }
        
    }

    private static string ExcludeWordsFromText(string text, List<string> list)
    {

        string expression = FormRegex(list);
        text = Regex.Replace(text, expression, "");

        return text;
    }

    private static string FormRegex(List<string> list)
    {
        var regex = new StringBuilder();
        for (int i = 0; i < list.Count; i++)
        {
            regex.Append(@"\b");
            regex.Append(list[i]);
            regex.Append(@"\b|");
        }

        return regex.ToString().TrimEnd('|');
    }

    private static List<string> AddExcludeWords()
    {
        var wordsToExclude = new List<string>();
        using (StreamReader reader = new StreamReader(@"../../list.txt"))
        {
            string word = reader.ReadLine();
            while (word != null)
            {
                wordsToExclude.Add(word);
                word = reader.ReadLine();
            }
        }

        return wordsToExclude;
    }
}
