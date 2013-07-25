/*Write a program that deletes from
 * given text file all odd lines.
 * The result should be in the same file.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class RemoveOddLines
{
    static void Main()
    {
        var list = new List<string>();
        using (StreamReader reader = new StreamReader(@"../../text.txt"))
        {
            string line = reader.ReadLine();
            int lineNumber = 1;

            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    list.Add(line);
                }
                lineNumber++;
                line = reader.ReadLine();
            }
        }

        using (StreamWriter writer = new StreamWriter(@"../../text.txt"))
        {
            int lines = list.Count;

            for (int i = 0; i < lines; i++)
            {
                writer.WriteLine(list[i]);
            }
        }
    }
}
