using System;

class PrintStringWithLength20
{
    static void Main()
    {
        Console.WriteLine("Input string with maximum length of 20 charachters: ");
        string input = Console.ReadLine();

        if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }

        Console.WriteLine(input);

    }
}
