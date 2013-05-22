/*Write a program that gets two numbers
 * from the console and prints the greater
 * of them. Don’t use if statements.
*/

using System;

class PrintGreaterWithoutIf
{
    static void Main()
    {
        Console.WriteLine("Input two numbers!");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
     
        Console.WriteLine(firstNumber > secondNumber ? "{0} is greater than {1}" : "{1} is greater than {0}", firstNumber, secondNumber);
    }
}
