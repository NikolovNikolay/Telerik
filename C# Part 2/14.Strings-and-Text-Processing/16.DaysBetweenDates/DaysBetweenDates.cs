/*Write a program that reads two dates in the
 * format: day.month.year and calculates the number of days between them.*/

using System;
using System.Globalization;

class DaysBetweenDates
{
    static void Main()
    {

        Console.Write("Enter first date: ");
        string firstDate = Console.ReadLine();
        DateTime fDate = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter second date: ");
        string secondDate = Console.ReadLine();
        DateTime sDate = DateTime.ParseExact(secondDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        TimeSpan days = sDate - fDate;
        Console.WriteLine(days.Days);
    }
}
