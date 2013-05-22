/*Declare a character variable and assign
 * it with the symbol that has Unicode code 72.
 * Hint: first use the Windows Calculator to find 
 * the hexadecimal representation of 72.
*/

using System;

class SymbolInUnicode
{
    static void Main()
    {
        // 72 in Dec is 48 in Hex
        char unicodeSymbol = '\u0048';
        Console.WriteLine("The symbol that has Unicode code 72 is {0}",unicodeSymbol);
    }
}

