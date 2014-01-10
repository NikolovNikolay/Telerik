/*Write a program that reads from the 
 * console a positive integer number N (N < 20) 
 * and outputs a matrix.
*/

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter a number N to create a matrix with N rows and N columns (N < 20): ");
        byte n = byte.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0,3}", i);
                for (int j = 1; j < n; j++)
                {
                    Console.Write("{0,3}", i + j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Enter valid N !");
        }
    }
}


