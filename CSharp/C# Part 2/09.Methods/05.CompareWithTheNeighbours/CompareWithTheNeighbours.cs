/*Write a method that checks if the element at 
 * given position in given array of integers is
 * bigger than its two neighbors (when such exist).
*/

using System;

class CompareWithTheNeighbours
{
    static void Main()
    {
        int[] array = new int[] { 5, 3, 6, 9, 10, 75, 8, 0, 23, 14, 1, 9, 8, 2, 44 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Choose an index to compare numbers: ");
        int index = int.Parse(Console.ReadLine());

        PrintResults(array, index); 
    }

    private static void PrintResults(int[] array, int index)
    {
        if (index >= 0 && index < array.Length)
        {
            if (CompareWithNeighbours(array, index))
            {
                Console.WriteLine("Number ({0}) is bigger than its both neighbour/s", array[index]);
            }
            else
            {
                Console.WriteLine("Number ({0}) is not bigger than its both neighbour/s", array[index]);
            }
        }
        else
        {
            Console.WriteLine("Index out of array!");
        }
    }

    static bool CompareWithNeighbours(int[] array, int numberIndex)
    {
        if (numberIndex - 1 >= 0 && numberIndex + 1 < array.Length)
        {
            if (array[numberIndex] > array[numberIndex + 1] && array[numberIndex] > array[numberIndex - 1])
            {
                return true;
            }
        }
        else if (numberIndex - 1 >= 0 && numberIndex + 1 >= array.Length)
        {
            if (array[numberIndex] > array[numberIndex - 1])
            {
                return true;
            }
        }
        else if (numberIndex - 1 < 0 && numberIndex + 1 < array.Length)
        {
            if (array[numberIndex] > array[numberIndex + 1])
            {
                return true;
            }
        }
       
        return false;
    }
}