/*
 * Write an expression that checks
 * if given positive integer number n
 * (n ≤ 100) is prime. E.g. 37 is prime.
*/

using System;

class PrimeOrNot
{
    static void Main()
    {
        Console.Write("Input Number: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        bool numberIsPrime = false;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        Console.Write("The number is prime: ");
        Console.Write(count > 2 ? numberIsPrime = false : numberIsPrime = true);
        Console.WriteLine();
    }
}
