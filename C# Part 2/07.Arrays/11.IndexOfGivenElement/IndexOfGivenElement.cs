/*
 * Write a program that finds the index of given element 
 * in a sorted array of integers by using the binary search
 * algorithm (find it in Wikipedia).
 * */


using System;

class IndexOfGivenElement
{
    static void Main()
    {
        int[] arr = { 3, 14, 20, 56, 34, 0, 2, 44, 98, 17, 20, 13, 94, 45, 66 };
        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0} ", arr[i]);
        }
        Console.Write("}");
        Console.WriteLine();
        Array.Sort(arr);

        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0} ", arr[i]);
        }
        Console.Write("}");
        Console.WriteLine();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Array.BinarySearch(arr, n));
    }
}

