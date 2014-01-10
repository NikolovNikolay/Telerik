/*Write a method that reverses the digits of given decimal number. Example: 256  652
*/

using System;

class ReverseDigitsOfADecimalNumber
{
    static string ReverseDigits(decimal number)
    {
        string decimalToString = number.ToString();
        string result = "";
        for (int i = decimalToString.Length - 1; i >= 0; i--)
        {
            result = result + decimalToString[i];
        }

        if (result != "0")
        {
            result = result.TrimStart(' ');
            result = result.TrimStart('0'); 
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Input decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDigits(number));
    }
}
