/*Write a program that reads three integer
 * numbers N, K and S and an array of N 
 * elements from the console. Find in the 
 * array a subset of K elements that have 
 * sum S or indicate about its absence*/

using System;

class SubsetOfKElements
{
    static void Main()
    {
        Console.Write("Enter quantity of elements in the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N]; 

        Console.Write("Subsum of how many elements: ");
        int K = int.Parse(Console.ReadLine());

        Console.Write("Wanted sum: ");
        int S = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
		{
            Console.Write("Enter element {0}: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
		}

        int currentSum = 0;
        string sequence = string.Empty;
        int combinations = (1<<N) - 1;
        int count = 0;

        for (int i = 0; i < combinations; i++)
        {
            sequence = string.Empty;
            currentSum = 0;
            count = 0;
            for (int j = 0; j < N; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sequence = sequence + " " + numbers[j];
                    currentSum += numbers[j];
                    count++;
                }
            }
            if (count == K && currentSum == S)
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
