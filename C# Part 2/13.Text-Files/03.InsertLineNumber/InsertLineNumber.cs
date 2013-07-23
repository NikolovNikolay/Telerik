/*Write a program that reads a text file and inserts
  * line numbers in front of each of its lines.
  * The result should be written to another text file.
*/

using System;
using System.Linq;
using System.IO;

class InsertLineNumber
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../SampleTextFile.txt");
        StreamWriter writer = new StreamWriter(@"../../result.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            int lineNumber = 1;
            while (line != null)
            {
                line = lineNumber + ". " + line;
                writer.WriteLine(line);
                lineNumber++;
                line = reader.ReadLine();
            }
            writer.Close();
        }

        reader = new StreamReader(@"../../result.txt");
        using (reader)
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}