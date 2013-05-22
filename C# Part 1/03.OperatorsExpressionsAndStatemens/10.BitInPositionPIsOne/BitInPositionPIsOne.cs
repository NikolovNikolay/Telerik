/*Write a boolean expression that returns
 * if the bit at position p (counting from 0)
 * in a given integer number v has value of 1.
 * Example: v=5; p=1  false*/

using System;

class BitInPositionPIsOne
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Input bit position, starting from 0: ");
        int positionP = int.Parse(Console.ReadLine());

        int mask = number >> positionP;
        int maskAndOne = mask & 1;
        bool bitIsOne = false;

        Console.Write("The bit in position {0} is 1: ",positionP);
        Console.Write(maskAndOne == 1 ? bitIsOne=true : bitIsOne = false);
        Console.WriteLine();
    }
}
