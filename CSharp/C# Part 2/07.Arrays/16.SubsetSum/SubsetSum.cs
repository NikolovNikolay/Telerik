/*We are given an array of integers and a number S.
 * Write a program to find if there exists a subset
 * of the elements of the array that has a sum S. */

using System;

class SubsetSum
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int arrayLength = array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Desired sum?");
        int S = int.Parse(Console.ReadLine());

        int sum = 0;
        int minCount = 0;
        string sequence = "";


        int allCombinations = (1<<arrayLength) - 1;
        for (int i = 1; i <= allCombinations; i++)
        {
            sum = 0;
            sequence = "";
            for (int j = 0; j < arrayLength; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum = sum + array[j];
                    sequence = sequence +"+" + array[j];
                }
            }
            if (sum == S)
            {
                minCount++;
                sequence = sequence.TrimStart('+');
                Console.WriteLine("yes ( {0} )", sequence);
            }
        }

        if (minCount == 0)
        {
            Console.WriteLine("no");
        }
    
    }
}
