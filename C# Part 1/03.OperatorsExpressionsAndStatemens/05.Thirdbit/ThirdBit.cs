/*Write a boolean expression for
 * finding if the bit 3 (counting from 0)
 * of a given integer is 1 or 0.*/


using System;

class ThirdBit
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = number >> 3;
        int maskAndOne = mask & 1;
        bool thirdBitIsOne = false;

        Console.Write("The third bit is 1: ");
        Console.Write(maskAndOne == 1 ? thirdBitIsOne = true : thirdBitIsOne = false);
        Console.WriteLine();
    }
}
