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
        Console.Write("Input length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = randomGenerator.Next(-4, 12);
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();

        Console.Write("How many elements to sum? ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Desired sum? ");
        int s = int.Parse(Console.ReadLine());

        int combinations = ((1 << n) - 1);
        int sum = 0;
        string sequence = "";
        int count = 0;
        int minCount = 0;

        for (int i = 1; i <= combinations; i++)
        {
            sum = 0;
            sequence = "";
            count = 0;
            for (int j = 0; j < n; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum = sum + array[j];
                    sequence = sequence + "+" + array[j];
                    count++;
                }
            }

            if (sum == s && count == k)
            {
                minCount++;
                sequence = sequence.TrimStart('+');
                Console.WriteLine("yes ( {0} )", sequence);
            }
        }

        if (minCount == 0)
        {
            Console.WriteLine("There is no such sequence in the array!");
        }
    }
}
