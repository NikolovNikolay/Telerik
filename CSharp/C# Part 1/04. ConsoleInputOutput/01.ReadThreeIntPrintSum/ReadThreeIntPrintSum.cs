/*Write a program that reads 3 integer numbers
 * from the console and prints their sum.
*/

using System;

class ReadThreeIntPrintSum
{
    static void Main()
    {
        Console.WriteLine("Input three numbers");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the three numbers is {0}", sum);
    }   
}
