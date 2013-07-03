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
        string result = "";

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

        for (int i = 0; i < numbers.Count; i++)
        {
            result = AddDigitsToString(numbers, result, i);
        }

        result = result.TrimStart('0');
        Console.WriteLine(result);
    }

    private static string AddDigitsToString(List<int> numbers, string result, int i)
    {
        switch (numbers[i])
        {
            case 0: result = result + "0000"; break;
            case 1: result = result + "0001"; break;
            case 2: result = result + "0010"; break;
            case 3: result = result + "0011"; break;
            case 4: result = result + "0100"; break;
            case 5: result = result + "0101"; break;
            case 6: result = result + "0110"; break;
            case 7: result = result + "0111"; break;
            case 8: result = result + "1000"; break;
            case 9: result = result + "1001"; break;
            case 10: result = result + "1010"; break;
            case 11: result = result + "1011"; break;
            case 12: result = result + "1100"; break;
            case 13: result = result + "1101"; break;
            case 14: result = result + "1110"; break;
            case 15: result = result + "1111"; break;
        }
        return result;
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
