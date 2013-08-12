/*Write a program that prints to the console 
 * which day of the week is today. Use System.DateTime.
*/

using System;

class WhichDayOfWeek
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today is " + date.DayOfWeek);
    }
}