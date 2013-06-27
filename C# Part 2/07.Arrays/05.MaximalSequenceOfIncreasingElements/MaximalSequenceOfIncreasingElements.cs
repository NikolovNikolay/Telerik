/*Write a program that finds the maximal 
 * increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/

using System;

class MaximalSequenceOfIncreasingElements
{
    static void Main()
    {
        int[] array = { 3, 5, 6, 7, 4, 2, 6, 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 6, 4, 9, 10, 11, 12, 14, 20, 21 };
        int arrayLength = array.Length;

        int count = 1;
        int maxCount = 1;
        int maxEnd = 0;
        int end = 0;

        for (int i = 0; i < arrayLength - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
                end = i + 1;
            }

            if (count > maxCount)
            {
                maxCount = count;
                maxEnd = end;
            }

            if (array[i] >= array[i + 1])
            {
                end = i;
                count = 1;
            }
        }


        Console.Write("{");
        for (int i = maxEnd - maxCount + 1; i <= maxEnd; i++)
        {
            if (i != maxEnd)
                Console.Write(array[i] + ",");
            else
                Console.Write(array[i]);
        }
        Console.Write("}");
        Console.WriteLine();
        }
        
}


