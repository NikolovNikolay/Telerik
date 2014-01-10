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
        List<string> list = ReadFile();

        WriteToFile(list);
    }

    private static void WriteToFile(List<string> list)
    {
        using (StreamWriter writer = new StreamWriter(@"../../text.txt"))
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }
        }
    }

    private static List<string> ReadFile()
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

        return list;
    }
}
