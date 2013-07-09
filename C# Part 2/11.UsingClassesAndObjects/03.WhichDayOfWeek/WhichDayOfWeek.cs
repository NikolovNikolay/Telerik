using System;

class WhichDayOfWeek
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today is " + date.DayOfWeek);
    }
}