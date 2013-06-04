/* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
*/

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[20];
        int arrayLength = array.Length;
        int[] multipliedArray = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i+1;
            //Console.WriteLine(array[i]);
        }

        for (int j = 0; j < multipliedArray.Length; j++)
        {
            multipliedArray[j] = array[j] * 5;
            Console.WriteLine(multipliedArray[j]);
        }

    }
}
//1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
