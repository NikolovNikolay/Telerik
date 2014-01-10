/*Write a program that gets a number n
 * and after that gets more n numbers and
 * calculates and prints their sum. 
*/
using System;

class NumberN
{
    static void Main()
    {
        Console.WriteLine("Input number: ");
        ulong number = ulong.Parse(Console.ReadLine());
        ulong sum = 0;

        for (ulong i = 1; i <= number; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum of the numbers from 1 to {0} is {1}", number, sum);
    }
}

