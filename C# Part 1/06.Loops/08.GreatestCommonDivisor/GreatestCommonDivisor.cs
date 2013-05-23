﻿/*Write a program that calculates the 
 * greatest common divisor (GCD) of given two numbers.
 * Use the Euclidean algorithm (find it in Internet).
*/

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Input two numbers to calculate their greatest common divisor ( GCD )");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int bigger = 0;
        int smaller = 0;
        int gCD = 0;

        Console.WriteLine("[{0} : {1}]", firstNumber,secondNumber);
        if (firstNumber != secondNumber && firstNumber >= 0 && secondNumber>=0)
        {
            if (firstNumber < secondNumber && firstNumber != 0)
            {
                bigger = secondNumber;
                smaller = firstNumber;
            }
            if (secondNumber < firstNumber && secondNumber != 0)
            {
                bigger = firstNumber;
                smaller = secondNumber;
            }
            for (int i = 1; i < bigger; i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    gCD = i;
                }
            }
            Console.WriteLine("GCD = {0}",gCD);
        }   
            if (firstNumber == 0 || secondNumber == 0)
            {
                if (firstNumber != 0 && secondNumber == 0)
                {
                    Console.WriteLine("GCD = {0}", firstNumber);
                }
                if (secondNumber != 0 && firstNumber == 0)
                {
                    Console.WriteLine("GCD = {0}", secondNumber);
                }
            }
    }
}

