/*Write a program that sorts an array of strings
 * using the quick sort algorithm.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QuickSort
{
    static void Main()
    {
        // creation and print of unsorted array
        Console.Write("Quantity of numbers in the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] unsortedArray = new int[N];
        Random randomGenerator = new Random();

        for (int i = 0; i < unsortedArray.Length; i++)
        {
            unsortedArray[i] = randomGenerator.Next(-100, 101);
        }

        for (int i = 0; i < unsortedArray.Length; i++)
        {
            Console.Write(" {0}", unsortedArray[i]);
        }
        Console.WriteLine();

        // sorting the array, using the QuickSort algorithm
        QuickSortMethod(unsortedArray, 0, unsortedArray.Length - 1);

        // print the neq sorted algorithm
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            Console.Write(" {0}", unsortedArray[i]);
        }
        Console.WriteLine();
    }

    // quicksort method
    public static void QuickSortMethod(int[] numbers, int left, int right)
    {
        int i = left, j = right;
        int pivotElement = numbers[(left + right) / 2];

        while (i <= j)
        {
            while (numbers[i].CompareTo(pivotElement) < 0)
            {
                i++;
            }

            while (numbers[j].CompareTo(pivotElement) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;

                i++;
                j--;
            }

            //recursive call
            if (left < j)
            {
                QuickSortMethod(numbers, left, j);
            }

            if (i < right)
            {
                QuickSortMethod(numbers, i, right);
            }
        }
    }
}
