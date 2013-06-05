/*We are given an array of integers and a number S.
 * Write a program to find if there exists a subset
 * of the elements of the array that has a sum S. */

using System;

class SubsetSum
{
    static void Main()
    {
        Console.Write("Desired sum: ");
        int wantedSum = int.Parse(Console.ReadLine());

        Console.Write("Enter quantity of digits: ");
        int digitsInArray = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[digitsInArray];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.WriteLine("Please enter digit {0}: ", i+1);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        int combinationsAvailable = (1 << digitsInArray) - 1;
        string sequence = string.Empty;
        int currentSum = 0;
        bool possible = false;

        for (int i = 0; i < combinationsAvailable; i++)
        {
            
            sequence = string.Empty;
            currentSum = 0;
            for (int j = 0; j < digitsInArray; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sequence = sequence + " " + arrayOfNumbers[j];
                    possible = true;
                    currentSum += arrayOfNumbers[j];
                }
            }
            if (currentSum == wantedSum)
            {
                Console.WriteLine("Yes: {0}", sequence);
            }
            if (!possible) Console.WriteLine("--");
        }
        
    }
}
