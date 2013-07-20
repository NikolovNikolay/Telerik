using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractTextFromHTML
{
    static void Main()
    {
        string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskillful .NET software engineers.</p></body></html>";

        MatchCollection collector = Regex.Matches(str, @"(?<=^|>)[^><]+?(?=<|$)");
        foreach (var item in collector)
        {
            Console.WriteLine(item);
        }
    }
}
