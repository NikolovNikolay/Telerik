/*Write a program that reads two positive integer
 * numbers and prints how many numbers p exist
 * between them such that the reminder of the 
 * division by 5 is 0 (inclusive). Example: p(17,25) = 2.
*/

using System;

class HowManyNumbrsDivideBy5
{
    static void Main()
    {
        Console.WriteLine("Input two positive numbers to see how many among them can be divided by 5 !");
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long count = 0;

        if (firstNumber > 0 && secondNumber > 0)
        {
            for (long i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
                else
                {
                    count = count;
                }
            }
            Console.WriteLine("There are {0} numbers, which can be divided by 5!", count);
        }
        else
        {
            Console.WriteLine("Please input two positive numbers!");
        }
    }
}


