/*Write a program that reads from the
 * console a string of maximum 20 characters. 
 * If the length of the string is less than 20,
 * the rest of the characters should be filled with '*'. 
 * Print the result string into the console.
*/

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
