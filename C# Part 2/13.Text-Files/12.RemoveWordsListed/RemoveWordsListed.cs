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
        using (StreamReader readerOne = new StreamReader(@"../../text.txt"))
        {
            string line = readerOne.ReadLine();
            List<string> words = new List<string>();

            using (StreamReader readerTwo = new StreamReader(@"../../list.txt"))
            {
                string word = readerTwo.ReadLine();
                while (word != null)
                {
                    words.Add(word);
                    word = readerTwo.ReadLine();
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(@"\b");
            for (int i = 0; i < words.Count; i++)
            {
                if (i != words.Count - 1)
                {
                    sb.Append(words[i]);
                    sb.Append('|');
                }
                else
                {
                    sb.Append(words[i]);
                }
            }
            sb.Append(@"\b");
            string regexExpression = sb.ToString();

            while (line != null)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    line = Regex.Replace(line, regexExpression, string.Empty, RegexOptions.IgnoreCase);
                    using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
                    {
                        writer.WriteLine(line);
                    }
                }

                line = readerOne.ReadLine();
            }
        }
        Console.WriteLine("result.txt created");
    }
}
