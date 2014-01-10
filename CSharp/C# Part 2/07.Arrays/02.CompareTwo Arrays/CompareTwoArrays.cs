/* Write a program that reads two arrays
 * from the console and compares them 
 * element by element.
*/

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("How many elements is an array? ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("Input elements for the first array");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Input elements for the second array");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. ", i + 1);
            if (firstArray[i] > secondArray[i]) Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
            if (firstArray[i] < secondArray[i]) Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
            if (firstArray[i] == secondArray[i]) Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
        }
    }
}

