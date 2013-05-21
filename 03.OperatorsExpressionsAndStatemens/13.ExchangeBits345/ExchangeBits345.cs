/*Write a program that exchanges
 * bits 3, 4 and 5 with bits 24, 25 and 26
 * of given 32-bit unsigned integer.
*/

using System;
using System.Text;

class ExchangeBits345
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        //converting the number to binary formatted string
        string numberToBinary = Convert.ToString(number, 2).PadLeft(30, '0');
        Console.WriteLine("Number in binary before exchange: {0}",numberToBinary);
        //Creating a new char array and assigning the the values of the numberToBinary string to Array array
        char[] array = new char[30];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = numberToBinary[i];
        }
        // exchanging the bit values as given
        char temp = '0';
        temp = array[26];
        array[26] = array[5];
        array[5] = temp;
        temp = array[25];
        array[25] = array[4];
        array[4] = temp;
        temp = array[24];
        array[24] = array[3];
        array[3] = temp;
        
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
        Console.WriteLine("The new number is: {0}",result);
    }
}
