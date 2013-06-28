using System;

class SortStringArray
{
    static void Main()
    {
        
        string[] array = { "asdasf", "ggreg", "pl", "x", "opirtiopiop", "gggg" };
        Console.WriteLine("Unsorted array: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine();

        SortArray(array);
        
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }



    static void SortArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                string tempStringOne = arr[i].ToString();
                string tempStringTwo = arr[j].ToString();
                if (tempStringOne.Length > tempStringTwo.Length)
                {
                    string switchString = arr[i];
                    arr[i] = arr[j];
                    arr[j] = switchString;
                }
            }
        }
    }
}
