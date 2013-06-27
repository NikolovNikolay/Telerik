/* Write a program that allocates array of 20 
 * integers and initializes each element by its 
 * index multiplied by 5. 
 * Print the obtained array on the console.
*/

using System;

class ArrayMultilyBy5Elements
{
    static void Main()
    {
        int[] integerArray = new int[20];

        for (int i = 0; i < integerArray.Length; i++)
        {
            integerArray[i] = i * 5;
            Console.Write("{0} ", integerArray[i]);
        }
    }
}

