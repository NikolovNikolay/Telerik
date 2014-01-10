/*
 * Write a program that exchanges bits {p, p+1, …, p+k-1) 
 * with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
*/

using System;

class ExchangeBitsP
{
    static void Main()
    {
        Console.Write("Input number: ");
        uint number = uint.Parse(Console.ReadLine());

        //converting the number to binary formatted string
        string numberToBinary = Convert.ToString(number, 2).PadLeft(30, '0');
        Console.WriteLine("Number in binary before exchange: {0}", numberToBinary);
        Console.WriteLine("Exchange bits: ");
        int b1 = int.Parse(Console.ReadLine());
        int b2 = int.Parse(Console.ReadLine());
        int b3 = int.Parse(Console.ReadLine());
        Console.WriteLine("With bits:");
        int q1 = int.Parse(Console.ReadLine());
        int q2 = int.Parse(Console.ReadLine());
        int q3 = int.Parse(Console.ReadLine());

        //Creating a new char array and assigning the the values of the numberToBinary string to array
        char[] array = new char[30];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numberToBinary[i];
        }
        Array.Reverse(array);

        // exchanging the bit values as given
        char temp = '0';
        temp = array[q3];
        array[q3] = array[b3];
        array[b3] = temp;
        temp = array[q2];
        array[q2] = array[b2];
        array[b2] = temp;
        temp = array[q1];
        array[q1] = array[b1];
        array[b1] = temp;
        Array.Reverse(array);

        // turning the rearranged array to string
        string exchangedArray = new string(array);

        //printing the rearranged array on the  console
        Console.Write("New number in binary after exchange: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();

        // converting the string to integer
        int result = Convert.ToInt32(exchangedArray, 2);
        Console.WriteLine("The new number is: {0}", result);
    }
}
