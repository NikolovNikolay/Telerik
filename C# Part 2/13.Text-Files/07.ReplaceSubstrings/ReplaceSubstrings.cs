using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceSubstrings
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
                    line = Regex.Replace(line, "start", "finish", RegexOptions.IgnoreCase);
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }

            }
        }
        Console.WriteLine("Result file generated!");
    }
}
