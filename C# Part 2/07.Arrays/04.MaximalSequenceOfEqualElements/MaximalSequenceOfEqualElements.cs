/*Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;

public class MaxSequenceInArray
{
    public static void Main()
    {
        Console.Write("Enter how many numbers would you like to compare? ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int len = 1;
        int greatestLen = 0;
        int maxNumer = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < array.Length -1; j++)
			{
                if (array[j] == array[j + 1])
            {
                len++;
            }
            else
            {
                if (len > greatestLen)
                {
                    greatestLen = len;
                    maxNumer = array[j];
                }
                len = 1;
			}
            
            if (len > greatestLen)
            {
                greatestLen = len;
                maxNumer = array[array.Length - 1];
            }
        }
        Console.WriteLine("The maximal equal sequence consists of {0} elements of number {1}", greatestLen, maxNumer);
    }
}