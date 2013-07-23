/*Write a program that concatenates two text files into another text file.
*/

using System;
using System.Linq;
using System.IO;

class ConcatenateTwoInOne
{
    static void Main()
    {
        string textOne = "";
        string textTwo = "";
        try
        {
            StreamReader reader = new StreamReader(@"../../FirstTextFile.txt");
            using (reader)
            {
                textOne = reader.ReadToEnd();
            }

            reader = new StreamReader(@"../../SecondTextFile.txt");
            using (reader)
            {
                textTwo = reader.ReadToEnd();
            }

            ConcatenateTwoStrings(textOne, textTwo);
        }
        catch
        {
            Console.WriteLine("Something went wrong! Check file paths or file contents.");
        }
        
    }

    static void ConcatenateTwoStrings(string firstStr, string secondStr)
    {
        bool exist = false;

        try
        {
            exist = File.Exists(@"../../result.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");
            using (writer)
            {
                writer.Write(firstStr + Environment.NewLine + secondStr);
            }
        }
        catch
        {
            Console.WriteLine("Something went wrong! Check file paths or file contents.");
        }
        finally
        {
            if (exist)
                Console.WriteLine("Text file \"result.txt\" re-created!");
            else
                Console.WriteLine("Text file \"result.txt\" created!");
        }
    }
}