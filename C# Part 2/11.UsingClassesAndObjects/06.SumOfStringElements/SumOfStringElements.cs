/*You are given a sequence of positive integer
 * values written into a string, separated by 
 * spaces. Write a function that reads these values
 * from given string and calculates their sum. */

using System;

class SumOfStringElements
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by spaces: ");
        string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result += int.Parse(input[i]);
        }
        
        Console.Write("Result = {0}",result);
        Console.WriteLine();
    }
}
