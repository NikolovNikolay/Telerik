/*Write a program that finds all prime numbers in 
 * the range [1...10 000 000]. Use the sieve of 
 * Eratosthenes algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int allNumbers = 10000000;

        for (int i = 0; i <= allNumbers; i++)
        {
            numbers.Add(i);
        }

        for (int i = 2; i < allNumbers; i++)
        {
            if (numbers[i] != 0)
            {
                for (int j = numbers[i] * 2; j <= allNumbers; j += numbers[i])
                {
                    numbers[j] = 0;
                }
                Console.Write("{0,10}", numbers[i]);
            }
        }
    }
}
