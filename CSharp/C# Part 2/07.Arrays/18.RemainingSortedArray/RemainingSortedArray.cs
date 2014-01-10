/** Write a program that reads an array of integers and 
 * removes from it a minimal number of elements in such 
 * way that the remaining array is sorted in increasing 
 * order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/

using System;
using System.Collections.Generic;

class RemainingSortedArray
{
    public static bool IsSorted(List<int> array)
    {
        bool isSorted = true;
        for (int i = 0; i < array.Count - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                isSorted = false;
            }
        }

        return isSorted;
    }

    public static void Main()
    {
        int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5, 6, 2, 3, 19, 23, 18, 40 };

        int length = 0;
        int maximalLength = 0;

        List<int> bestSequence = new List<int>();
        int combinations = (1 << array.Length) - 1;

        for (int i = 1; i < combinations; i++)
        {
            List<int> sequence = new List<int>();
            for (int j = 0; j < array.Length; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    length++;
                    sequence.Add(array[j]);
                }
            }

            if (IsSorted(sequence))
            {
                if (length > maximalLength)
                {
                    maximalLength = length;
                    bestSequence = sequence;
                }
            }

            length = 0;
        }

        for (int i = 0; i < bestSequence.Count; i++)
        {
            Console.Write("{0} ", bestSequence[i]);
        }
        Console.WriteLine();
    }
}

