/*You are given a text. Write a 
 * program that changes the text
 * in all regions surrounded by the
 * tags <upcase> and </upcase> to uppercase.
 * The tags cannot be nested. Example:
*/
using System;
using System.Globalization;
using System.Threading;

class UpcaseTag
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        string text = @"Lorem ipsum dolor sit <upcase>amet, consectetur</upcase> adipisicing elit, 
sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
Ut enim ad minim <upcase>veniam</upcase>, quis nostrud exercitation ullamco laboris 
nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in
reprehenderit in <upcase>voluptate velit esse cillum dolore</upcase> eu fugiat nulla
pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa
qui officia deserunt mollit anim id est <upcase>laborum</upcase>.";

        int start = 0;
        int end = 0;

        for (int i = 0; i < text.Length - 8; i++)
        {
            if (text.Substring(i, 8) == "<upcase>")
            {
                start = i + 8;
            }

            if (text.Substring(i, 9) == "</upcase>")
            {
                end = i;
                int length = end - start;

                string changeToUpper = text.Substring(start, length).ToUpperInvariant();
                // the sequence of actions here is important, because we need to save the correct indexes end, start 
                // (we remove exact quantity of chars, but we insert them right away

                //removing the text which sould be in upper case
                text = text.Remove(start, length);
                // insering the upper case text at same start spot, with the same length as the removed one
                text = text.Insert(start, changeToUpper);
                // removing again first the end tag, not to affect the indexes
                text = text.Remove(end, 9);
                // removing the first upper tag
                text = text.Remove(start - 8, 8);
            }
        }
        Console.WriteLine(text);
    }
}
