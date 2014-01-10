/*Write an expression that extracts
 * from a given integer i the value 
 * of a given bit number b. 
 * Example: i=5; b=2  value=1.
*/

using System;

class ExtractBitInPositionN
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int b = int.Parse(Console.ReadLine());

        int mask = number >> b;
        int maskAndOne = mask & 1;

        Console.WriteLine("The bit in position {0} is {1}", b, maskAndOne);
    }
}
