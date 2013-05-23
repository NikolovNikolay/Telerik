/*Write a program that reads from the console a
 * sequence of N integer numbers and returns the
 * minimal and maximal of them.
*/

using System;

class ReadNReturnMaxMin
{
    static void Main()
    {
        Console.Write("Please enter how many numbers would you like to compare: ");
        int count = int.Parse(Console.ReadLine());
        int smallestValue = int.MaxValue;
        int greatestValue = int.MinValue;
     
        for (int i = 1; i <= count; i++)
        {
            Console.Write("Input numeber {0}: ", i);
            int value = int.Parse(Console.ReadLine());
           
            if (value > greatestValue)
            {
                greatestValue = value;
            }
            if(value < smallestValue)
            {
                smallestValue = value;
            }
        }
        Console.WriteLine("The smallest value is {0}: ", smallestValue);
        Console.WriteLine("The greatest value is {0}: ", greatestValue);
    }
}

