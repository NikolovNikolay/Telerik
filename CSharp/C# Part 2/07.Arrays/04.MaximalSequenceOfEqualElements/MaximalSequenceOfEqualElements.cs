/*Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;

public class MaxSequenceInArray
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 5, 6, 2, 2, 6, 6, 6, 6, 6, 6, 6, 7 };
        //Random randomGenerator = new Random();

        //for (int i = 0; i < 10; i++)
        //{
        //    array[i] = randomGenerator.Next(1, 6);
        //}

        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(array[i] + " ");
        //}

        int counter = 1;
        int maxCounter = 0;
        string sequence = string.Empty;
        string bestSequence = string.Empty;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                sequence = array[i].ToString();
            }

            if (counter > maxCounter)
            {
                maxCounter = counter;
                bestSequence = sequence;
            }

            if (array[i] != array[i + 1])
            {
                sequence = "";
                counter = 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Length of best sequence: {0}", maxCounter);
        Console.Write("{");
        for (int i = 0; i < maxCounter; i++)
        {
            if (i == maxCounter - 1)
                Console.Write(bestSequence);
            else
                Console.Write(bestSequence + ",");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}