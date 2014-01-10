/*A dictionary is stored as a sequence of text 
 * lines containing words and their explanations.
 * Write a program that enters a word and 
 * translates it by using the dictionary. */

using System;
using System.Text;

class Dictionary
{
    static void Main()
    {
        string[] dictionary = {
        ".NET - platform for applications from Microsoft",
        "CLR - managed execution environment for .NET",
        "namespace - hierarchical - organization of classes" };

        string search = "clr";

        Console.WriteLine("Search for: {0}", search);
        bool resultAvailable = false;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < dictionary.Length; i++)
        {
            if (dictionary[i].IndexOf(search, StringComparison.InvariantCultureIgnoreCase) != -1)
            {
                resultAvailable = true;
                for (int j = dictionary[i].IndexOf(search) + search.Length + 3; j < dictionary[i].Length; j++)
                {
                    sb.Append(dictionary[i][j]);
                }
                break;
            }
        }

        if (resultAvailable)
        {
            string result = sb.ToString();
            result = result.TrimStart(' ');
            Console.WriteLine("result: \"{0}\"", result);
        }
        else
        {
            Console.WriteLine("Can't find result!");
        }
    }
}
