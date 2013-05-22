/*Find online more information about ASCII 
 * (American Standard Code for Information Interchange)
 * and write a program that prints the entire ASCII table 
 * of characters on the console.
*/

using System;
using System.Text;

class ASCIIcharPrint
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 256; i++)
        {
            char asciiSymbol = (char)i;
            Console.WriteLine("{0} {1}", i,asciiSymbol);
        }
    }
}

