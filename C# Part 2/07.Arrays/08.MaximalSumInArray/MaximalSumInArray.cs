
using System;

class MaximalSumInArray
{
    static void Main()
    {
        //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8, 98, 100, 54, -34 };
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        //List<int> bestElements = new List<int>();
        //List<int> elements = new List<int>();
        int sum = 0;
        int maximalSum = 0;
        string elements = string.Empty;
        string bestElements = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
            elements = elements + " " + array[i];

            if (sum > maximalSum)
            {
                maximalSum = sum;
                bestElements = elements;
            }

            if (sum < 0)
            {
                sum = 0;
                elements = string.Empty;
            }

        }

        Console.WriteLine("The maximal sum is: " + maximalSum);
        Console.WriteLine("{" + bestElements + " }");

    }
}


