using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Input decimal number: ");
        int number = int.Parse(Console.ReadLine());

        List<string> characters = new List<string>();

        while (true)
        {
            if (number > 0)
            {
                int remainder = number % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10: characters.Add("A"); break;
                        case 11: characters.Add("B"); break;
                        case 12: characters.Add("C"); break;
                        case 13: characters.Add("D"); break;
                        case 14: characters.Add("E"); break;
                        case 15: characters.Add("F"); break;
                    }
                }
                else
                {
                    characters.Add(remainder.ToString());
                }
                number /= 16;
            }
            else
            {
                break;
            }

            
        }
        characters.Reverse();
        Console.Write("0x");
        foreach (var character in characters)
        {
            Console.Write(character);
        }
        Console.WriteLine();
    }
}