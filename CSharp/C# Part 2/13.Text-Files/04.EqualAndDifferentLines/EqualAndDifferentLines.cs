/*Write a program that compares two text
 * files line by line and prints the number
 * of lines that are the same and the number 
 * of lines that are different. Assume the files 
 * have equal number of lines.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EqualAndDifferentLines
{
    static void Main()
    {
        StreamReader readerFileOne = new StreamReader(@"../../fileOne.txt");
        StreamReader readerFileTwo = new StreamReader(@"../../fileTwo.txt");
        

        int equalLines = 0;
        int differentLines = 0;

        int lineNumber = 0;
        using (readerFileOne)
        {
            using (readerFileTwo)
            {
                while (true)
                {
                    lineNumber++;
                    string lineFileOne = readerFileOne.ReadLine();
                    string lineFileTwo = readerFileTwo.ReadLine();
                    if (lineFileOne == lineFileTwo)
                        equalLines++;
                    else
                        differentLines++;

                    if (lineFileOne == null && lineFileTwo == null)
                        break;
                }
            }
        }
        Console.WriteLine("Same lines are: {0}, and different are: {1}", equalLines, differentLines);
    }
}
