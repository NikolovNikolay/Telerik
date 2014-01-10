/*Write a program that finds how many
 * times a substring is contained in a
 * given text (perform case insensitive search).
*/

using System;

class ContainedSubstring
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't
                        have anything else. Inside the submarine is very tight.
                        So we are drinking all the day. We will move out of it 
                        in 5 days.";

        int counter = 0;
        int index = 0;

        while (true)
        {
            if (text.IndexOf("in", index, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                counter++;
                index = text.IndexOf("in", index, StringComparison.CurrentCultureIgnoreCase) + 1;
            }
            else
            {
                break;
            }
        }

        if (counter > 0)
        {
            Console.WriteLine(counter);
        }
        else
        {
            Console.WriteLine("Not available substring");
        }
    }
}
