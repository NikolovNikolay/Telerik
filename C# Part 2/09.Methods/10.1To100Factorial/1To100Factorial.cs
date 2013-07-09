/*Write a program to calculate n! for each n
 * in the range [1..100]. Hint: Implement
 * first a method that multiplies a number
 * represented as array of digits by given integer number. 
*/

using System;
using System.Numerics;

class Factorial
{
    static BigInteger CalculateFactorial(int number)
    {
        BigInteger result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i; 
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Calculate to: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Factorial to {0}: {1}", i, CalculateFactorial(i));
        }
    }
}

