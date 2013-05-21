/*Write a boolean expression that checks 
 * for given integer if it can be divided
 * (without remainder) by 7 and 5 in the same time.*/


using System;

class DivideByFiveAndSeven
{
    static void Main()
    {
        bool dividedByFiveAndSeven = false;
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            dividedByFiveAndSeven = true;
        }
        else
        {
            dividedByFiveAndSeven = false;
        }
        Console.Write("The number can be divided by 5 and 7: ");
        Console.Write(dividedByFiveAndSeven ? dividedByFiveAndSeven : dividedByFiveAndSeven);
        Console.WriteLine();
    }
}
