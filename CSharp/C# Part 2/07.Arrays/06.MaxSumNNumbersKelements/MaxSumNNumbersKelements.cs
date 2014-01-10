/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
*/

using System;

class MaxSumNNumbersKelements
{
    static void Main()
    {
        Console.WriteLine("Array length?");
        int arrayLength = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();

        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = randomGenerator.Next(1, 15);
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Elements to sum:");
        int elements = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int maximalSum = 0;
        string numbers = string.Empty;
        string numsWithMaxSum = string.Empty;

        for (int i = 0; i < arrayLength; i++)
        {
            numbers = string.Empty;
            if (i + elements > array.Length)
            {
                break;
            }

            for (int j = i; j < i + elements; j++)
            {
                currentSum = currentSum + array[j];
                numbers = numbers + " " + array[j];
            }

            if (currentSum > maximalSum)
            {
                maximalSum = currentSum;
                numsWithMaxSum = numbers;
            }

            currentSum = 0;
        }
        Console.WriteLine("Elements with maximal sum:{0}", numsWithMaxSum);
        Console.WriteLine("Their sum is {0}", maximalSum);
    }
}