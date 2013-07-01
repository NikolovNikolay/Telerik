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

        result = result.TrimStart(' ');
        result = result.TrimStart('0');
        return result;
    }

    static void Main()
    {
        Console.Write("Input number with a floating point: ");
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDigits(number));
    }
}
