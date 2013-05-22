/*We are given 5 integer numbers. Write a program
 * that checks if the sum of some subset of them is 0.
 * Example: 3, -2, 1, 1, 8  1+1-2=0.*/

using System;
using System.Text;

class SubsetSumZero
{
    static void Main()
    {
        
        int sum = 0;
        StringBuilder strBuild = new StringBuilder();

        // Declare an array with random generated integers
        int[] array = new int[10];
        Random randomGenerator = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomGenerator.Next(-2, 10);
        }

        //Print the integers in the array on the console
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0} ", array[i]);
        }
        Console.WriteLine();

        //Input the subsum
        Console.Write("Please enter the subset sum you want to check: ");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Generate sum algorithm
        Console.WriteLine("Available combinations for the subsum in the array, are:");
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                strBuild.Append(array[j]).Append(" ");
                if (sum == wantedSum)
                {
                    Console.WriteLine(strBuild);
                }
            }
            strBuild.Clear();
            sum = 0;
        }
    }
}