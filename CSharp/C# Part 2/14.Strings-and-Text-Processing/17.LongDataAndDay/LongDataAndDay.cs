/*Write a program that reads a date and time given 
 * in the format: day.month.year hour:minute:second
 * and prints the date and time after 6 hours and 30
 * minutes (in the same format) along with the day 
 * of week in Bulgarian.
*/

using System;
using System.Globalization;

class LongDataAndDay
{
    static void Main()
    {
        Console.WriteLine("Enter day.month.year hour:minute:second");
        string longDate = Console.ReadLine();

        DateTime date = DateTime.ParseExact(longDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6.5);
        string dayOfWeek = date.ToString("dddd", new CultureInfo("bg-BG"));

        Console.WriteLine("{0} {1}", dayOfWeek, date);
    }
}