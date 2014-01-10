/*Write a program that finds all prime numbers in 
 * the range [1...10 000 000]. Use the sieve of 
 * Eratosthenes algorithm (find it in Wikipedia).
*/

using System;


class SieveOfEratosthenes
{
    static void Main()
    {
        int n = 10000000;
        bool[] array = new bool[n];

        for (int i = 2; i < array.Length; i++)
        {
            array[i] = true;
        }

        for (int i = 2; i < n; i++)
        {
            if (array[i] == true)
            {
                for (int j = i * 2; j < n; j += i)
                {
                    array[j] = false;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (array[i] == true)
            {
                Console.Write("{0,10}", i);
            }
        }
    }
}
