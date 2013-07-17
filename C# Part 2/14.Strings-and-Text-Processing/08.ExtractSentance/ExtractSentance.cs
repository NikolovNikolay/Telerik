/*Write a program that extracts from a given text all sentences containing given word.
 * Consider that the sentences are separated by "." and the words – by non-letter symbols.
*/

using System;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

class ExtractSentance
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.Write("Enter word to search for (note that there won't be any difference\nbetween \"in\" and \"In\"): ");
        string wordToSearch = Console.ReadLine();

        int start = 0;
        int end = 0;
        int length = 0;
        StringBuilder sb = new StringBuilder();
        bool answerAvailable = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.')
            {
                end = i;
                length = end - start;
                

                for (int j = start; j <= start + length; j++)
                {
                    sb.Append(text[j]);
                }
                string sentance = sb.ToString();

                int index = 1;

                while (index <= sentance.Length - 1)
                {

                    if ((sentance.IndexOf(wordToSearch, index, StringComparison.InvariantCultureIgnoreCase) != -1 && sentance[sentance.IndexOf(wordToSearch, index, StringComparison.InvariantCultureIgnoreCase) - 1] == ' ' &&
                        sentance[sentance.IndexOf(wordToSearch, index, StringComparison.InvariantCultureIgnoreCase) + wordToSearch.Length] == ' ' || sentance[sentance.IndexOf(wordToSearch, index, StringComparison.InvariantCultureIgnoreCase) + wordToSearch.Length] == '.' ||
                        sentance[sentance.IndexOf(wordToSearch, index, StringComparison.InvariantCultureIgnoreCase) + wordToSearch.Length] == ',') || (sentance.IndexOf(wordToSearch, StringComparison.InvariantCultureIgnoreCase) == 0 && sentance[sentance.IndexOf(wordToSearch, StringComparison.InvariantCultureIgnoreCase) + wordToSearch.Length] == ' '))
                    {
                        answerAvailable = true;
                        sentance = sentance.TrimStart(' ');
                        Console.WriteLine(sentance);
                        break;
                    }
                        index++;
                }
                sb.Clear();
                sentance = "";
                start = i + 1;
            }
        }
        if (!answerAvailable)
        {
            Console.WriteLine("Can not find word!");
        }
    }
}
