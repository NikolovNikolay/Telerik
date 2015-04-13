/*Write a program that prints all the numbers from 1 to N.
*/

using System;

class PrintNumbersOneToTen
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());

        // First method
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ",i);
        }

        Console.WriteLine();

        // Second method
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ",array[i]);
        }

        Console.WriteLine();
    }
}

