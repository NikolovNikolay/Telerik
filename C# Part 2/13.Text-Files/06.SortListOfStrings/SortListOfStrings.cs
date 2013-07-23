using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortListOfStrings
{
    static void Main()
    {
        string[] words;
        using (StreamReader reader = new StreamReader(@"../../input.txt"))
        {
            string line = reader.ReadLine();
            int lineNumber = 1;
            StringBuilder sb = new StringBuilder();
            
            while (line != null)
            {
                sb.AppendFormat("{0} ",line);
                lineNumber++;
                line = reader.ReadLine();
            }
            char[] splitter = new char[] { ' ' };
            words = sb.ToString().Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);

            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                for (int i = 0; i < words.Length; i++)
                {
                    writer.WriteLine(words[i]);
                }
            }
        }
        Console.WriteLine("Result file generated!");
    }
}
