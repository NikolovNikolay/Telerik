using System;

class ReturnMaxElementInAPortionOfArray
{
    static void Main()
    {
        int[] array = { 4, 6, 9, 5, 0, 1, 5, 12, 78, 9, 2, 14 };
        Console.WriteLine("Choose index to start from (0 <= i < {0}): ", array.Length);
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Max number is at index: {0}", FindMaxInAPortion(array, index));
        Console.WriteLine("Ascending? Enter true/false");
        bool ascending = bool.Parse(Console.ReadLine());

        array = SortArray(array, ascending);

        Console.WriteLine("New array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int FindMaxInAPortion(int[] array, int index)
    {
        int maxElement = 0;
        int biggestNumberIndex = 0;

        for (int i = index; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                int bigger = array[i];
                if (bigger > maxElement)
                {
                    maxElement = bigger;
                    biggestNumberIndex = i;
                }
            }

            if (array[i] < array[i + 1])
            {
                int bigger = array[i + 1];
                if (bigger > maxElement)
                {
                    maxElement = bigger;
                    biggestNumberIndex = i + 1;

                }
            }
        }

        return biggestNumberIndex;
    }

    static int[] SortArray(int[] array, bool ascending)
    {
        for (int i = 0; i < array.Length- 1; i++)
        {
            int max = FindMaxInAPortion(array, i);
            int temp = array[i];
            array[i] = array[max];
            array[max] = temp;
        }

        if (ascending)
        {
            Array.Reverse(array);
        }
        return array;
    }
}
