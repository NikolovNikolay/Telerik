/*Write a program to print the first 100 members of the sequence of 
 * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/

using System;

class FirstHundredFibonacci
{
    static void Main()
    {
        ulong previousNumber = 0;
        ulong actualNumber=1;
        ulong nextNumber=0;

        Console.WriteLine("The first 100 Fibonacci members are: ");
        Console.WriteLine("1 -> {0}",previousNumber);
        Console.WriteLine("2 -> {0}",actualNumber);
        for (int i = 1; i <= 98; i++)
        {
            nextNumber = previousNumber + actualNumber;
            previousNumber = actualNumber;
            actualNumber = nextNumber;
            Console.WriteLine("{0} -> {1}",i+2,nextNumber);
        }
    }
}

