/*Sorting an array means to arrange its elements
 * in increasing order. Write a program to sort 
 * an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first 
 * position, find the smallest from the rest,
 * move it at the second position, etc.
*/
using System;

class SortNumbersInAnArray
{
    static void Main()
    {
        // first way
        int[] array = { 19, 45, 32, 9, 10, 100000000, 5, 3, 4, 100, 78 };
        Console.WriteLine("Unsorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }


        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        //second way

        //Console.Write("Enter array's length: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //int min = 0;

        //Console.WriteLine("Enter numbers: ");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < array.Length - 1; i++)
        //{
        //    min = i;
        //    for (int j = i + 1; j < array.Length; j++)
        //    {
        //        if (array[j] < array[min])
        //        {
        //            min = j;
        //        }
        //    }

        //    if (min != i)
        //    {
        //        int temp = 0;
        //        temp = array[i];
        //        array[i] = array[min];
        //        array[min] = temp;
        //    }
        //}
        //Console.Write("The sorted array is: ");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write("{0} ", array[i]);
        //}
    }
}

