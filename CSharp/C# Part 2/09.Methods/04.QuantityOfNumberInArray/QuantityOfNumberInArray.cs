/*Write a method that counts how many 
 * times given number appears in given 
 * array. Write a test program to check 
 * if the method is working correctly.
*/

using System;

class QuantityOfNumberInArray
{
    static int CheckNumberInArray(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] array = new int[] {1,5,6,9,8,7,4,5,2,3,6,5,2,1,7,8,9,6,5,2};

        PrintArray(array);

        Console.Write("Pick a digit to check for its quantity: ");
        Console.WriteLine(CheckNumberInArray(array, int.Parse(Console.ReadLine())));
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
