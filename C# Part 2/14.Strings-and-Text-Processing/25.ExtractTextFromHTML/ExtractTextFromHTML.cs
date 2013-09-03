/*Write a program that extracts from 
 * given HTML file its title (if available),
 * and its body text without the HTML tags.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

class ExtractTextFromHTML
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        string str = "";
        using (StreamReader reader = new StreamReader("input.html"))
        {
            string line = "";
            while (line != null)
            {
                line = reader.ReadLine();
                if ( line != null)
                sb.Append(line.Trim());
            }
        }

        str = sb.ToString();
        //str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";

        MatchCollection collector = Regex.Matches(str, @"(?<=^|>)[^><]+?(?=<|$)", RegexOptions.IgnorePatternWhitespace);
        foreach (var item in collector)
        {
            Console.WriteLine(item);
        }
    }
}
