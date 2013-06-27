/*Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.Write("How many elements is an array? ");
        int n = int.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        char[] secondArray = new char[n];
        Console.WriteLine("For a correct comparison, use only capital or small letters!");
        Console.WriteLine("Input elements for the first array");
        for (int i = 0; i < n; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Input elements for the second array");
        for (int i = 0; i < n; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. ", i + 1);
            if (firstArray[i] > secondArray[i]) Console.WriteLine("{0} comes later than {1}", firstArray[i], secondArray[i]);
            if (firstArray[i] < secondArray[i]) Console.WriteLine("{0} comes earlier than {1}", firstArray[i], secondArray[i]);
            if (firstArray[i] == secondArray[i]) Console.WriteLine("{0} is equal to {1}", firstArray[i], secondArray[i]);
        }
    }
}

