/*Write a program that extracts from a 
 * given text all dates that match the
 * format DD.MM.YYYY. Display them in 
 * the standard date format for Canada.
*/

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

class Extractdates
{
    static void Main()
    {
        
        string text = "alalalalalala balalaa 18.07.2012, 21.09.2100, 32.01.2011 jndfn";
        DateTime date = new DateTime();

        MatchCollection results = Regex.Matches(text, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}");

        for (int i = 0; i < results.Count; i++)
        {
            if (DateTime.TryParse(results[i].ToString(), out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
