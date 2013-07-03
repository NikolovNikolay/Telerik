using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Input a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        List<int> binaryDigits = new List<int>();

        while (true)
        {
            if (number > 0)
            {
                int remainder = (int) number % 2;
                binaryDigits.Add(remainder);
                number /= 2;
            }
            else
            {
                break;
            }
        }

        binaryDigits.Reverse();
        string binary = "";

        for (int i = 0; i < binaryDigits.Count; i++)
        {
            binary = binary + binaryDigits[i];
        }
        binary = binary.TrimStart('0');
        Console.WriteLine(binary);
    }
}

