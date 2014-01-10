/*Write a program that deletes from 
 * a text file all words that start
 * with the prefix "test". Words
 * contain only the symbols 0...9,
 * a...z, A…Z, _.
*/

using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWord
{
    static void Main()
    {
        using(StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                line = Regex.Replace(line, @"\btest\w*\b", string.Empty);
                using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
                {
                    writer.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
        Console.WriteLine("Result file created!");
    }
}
