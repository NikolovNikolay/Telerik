/*Write a program that reads two numbers N
 * and K and generates all the combinations
 * of K distinct elements from the set [1..N].
 * Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/

using System;

class CombinationsNK
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements:");
        long numberOfElements = long.Parse(Console.ReadLine());

        Console.WriteLine("Enter K:");
        long combinationElements = long.Parse(Console.ReadLine());

        long[] elements = new long[numberOfElements];
        string subset = string.Empty;
        int lenCounter = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            Console.WriteLine("Enter element № {0}", i + 1);
            elements[i] = long.Parse(Console.ReadLine());
        }

        int maxSubsets = (int)Math.Pow(2, numberOfElements);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = string.Empty;
            for (int j = 0; j <= numberOfElements; j++)
            {
                if (((i>>j) & 1) == 1)
                {
                    subset = subset + " " + elements[j];
                    lenCounter++;
                }
            }

            if (lenCounter == combinationElements)
            {
                Console.WriteLine(subset);
            }

            lenCounter = 0;
        }
    }
}
