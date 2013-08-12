/*Write a program that reads a year from 
 * the console and checks whether it is a leap. Use DateTime.
*/

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} is a leap year? - {1}",year,DateTime.IsLeapYear(year));
    }
}
