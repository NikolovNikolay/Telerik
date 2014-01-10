/*Write a program for extracting all
 * email addresses from given text. All
 * substrings that match the format
 * <identifier>@<host>…<domain> should 
 * be recognized as emails.
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Ala bala portokala jijibiji@abv.bg, telerik academy tva onova yohoho@dvebutilki.rom. Loren ipsum,somemail@gmail.com, and yahoo_s@mail.bg.";
        
        // first way using regular expressions
        MatchCollection collector = Regex.Matches(text, @"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})");
        foreach (var item in collector)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //second way
        int index = 0;
        StringBuilder sb = new StringBuilder();

        while (index < text.Length)
        {
            int start = 0;
            int end = 0;
            int dotCount = 0;

            if (text[index] == '@')
            {
                for (int i = index; i >= 0; i--)
                {
                    if (text[i] == ' ' || text[i] == ',')
                    {
                        start = i + 1;
                        break;
                    }
                }

                for (int i = index; i < text.Length; i++)
                {

                    if ((text[i] == ',' || text[i] == '.' || text[i] == ' ') && dotCount > 0)
                    {
                        end = i - 1;
                        break;
                    }
                    if (text[i] == '.')
                    {
                        dotCount++;
                    }

                }

                for (int i = start; i <= end; i++)
                {
                    sb.Append(text[i]);
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
            }

            index++;
        }

    }
}
