﻿/*Modify the solution of the previous problem to replace only whole words (not substrings).

*/

using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWords
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            string line = reader.ReadLine();
            int lineNumber = 1;

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                while (line != null)
                {
                    line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }

            }
        }
        Console.WriteLine("Result file generated!");
    }
}
