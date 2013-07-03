using System;
using System.Collections.Generic;

class HexadeciamalToDecimal
{
    static void Main()
    {
        Console.Write("Enter number in Hexadecimal: 0x");
        string number = Console.ReadLine();

        List<int> numbers = new List<int>();

        int power = 0;
        int result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != 'A' && number[i] != 'B' && number[i] != 'C' && number[i] != 'D' && number[i] != 'E' && number[i] != 'F')
            {
                numbers.Add(Convert.ToInt32(new string(number[i], 1)));
            }
            else
            {
                AddIntToList(number, numbers, i);
            }
        }

        for (int i = numbers.Count -1; i >= 0; i--)
        {
            result = result + numbers[i] * (int)Math.Pow(16, power);
            power++;
        }

        Console.WriteLine(result);
    }

    private static void AddIntToList(string number, List<int> numbers, int index)
    {
        if (number[index] == 'A') numbers.Add(10);
        if (number[index] == 'B') numbers.Add(11);
        if (number[index] == 'C') numbers.Add(12);
        if (number[index] == 'D') numbers.Add(13);
        if (number[index] == 'E') numbers.Add(14);
        if (number[index] == 'F') numbers.Add(15);
    }
}
