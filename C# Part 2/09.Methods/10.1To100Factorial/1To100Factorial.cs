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

