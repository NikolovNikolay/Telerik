/*Write a program that reads a number
 * N and calculates the sum of the first
 * N members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/

using System;
using System.Numerics;

class FirstNMembersOfFibonacci
{
    static void Main()
    {
        Console.Write("How many Fibonacci numbers would you like to calculate? ");
        int totalNumbers = Int32.Parse(Console.ReadLine());
        BigInteger previousNumber = 0;
        BigInteger actualNumber = 1;
        BigInteger nextNumber;

        Console.WriteLine("Number 1 is: 0 ");
        Console.WriteLine("Number 2 is: 1 ");

        for (int i = 3; i <= totalNumbers; i++)
        {
            nextNumber = previousNumber + actualNumber;
            previousNumber = actualNumber;
            actualNumber = nextNumber;

            Console.WriteLine("Number {0} is: {1} ", i,actualNumber);
        }
    }
}

