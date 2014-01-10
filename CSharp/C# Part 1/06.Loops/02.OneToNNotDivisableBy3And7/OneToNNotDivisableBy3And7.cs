/*Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
*/

using System;

class OneToNNotDivisableBy3And7
{
    static void Main()
    {
        Console.Write("Enter number n= ");
        int number = Int32.Parse(Console.ReadLine());
        Console.Write("The numbers which can not be divided to 3 and 7 are: ");
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i); ;
            }
        }
    }
}

