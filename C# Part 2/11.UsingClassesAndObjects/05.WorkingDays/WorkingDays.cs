using System;

static class WorkingDays
{
    static void Main()
    {
        DateTime[] holidays = { new DateTime(2013, 5, 6), new DateTime(2013, 9, 6),    new DateTime (2013, 12, 24), new DateTime(2013, 12,24),
                                new DateTime(2013, 9,22), new DateTime(2013, 11, 1),   new DateTime (2013, 12,26),  new DateTime (2013, 12, 31),
                                new DateTime(2014, 1, 1), new DateTime (2014, 1,2),    new DateTime (2014,3,3),     new DateTime (2014,5,6), 
                                new DateTime(2014, 9, 6), new DateTime (2014, 12, 24), new DateTime(2014, 12,24),   new DateTime(2014, 9,22), 
                                new DateTime(2014, 11, 1), new DateTime (2014, 12,26), new DateTime (2014, 12, 31) };
        
        DateTime today = DateTime.Now;
        Console.WriteLine("Input dd/mm/yyyy, as follows:");
        int date = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime endDate = new DateTime(year, month, date);
        Console.WriteLine("There are {0} working days in the period.", CalculateBusinessDays(today, endDate, holidays));
    }

    static int CalculateBusinessDays(DateTime startDate, DateTime endDate, params DateTime[] holidays)
    {
        int startDay = startDate.DayOfYear;
        int endDay = endDate.DayOfYear;
        if (endDate.Year < startDate.Year || (endDate.Year == startDate.Year && endDate.DayOfYear < startDate.DayOfYear))
            throw new ArgumentException("Incorrect day or year " + endDay);
        int businessDays = endDay - startDay + 1;

        if (endDate.Year > startDate.Year)
        {
            businessDays = businessDays + ((endDate.Year - startDate.Year) * 365);
        }
        int loops = businessDays;
        for (int i = 1, j = startDay; i <= loops; i++, j++)
        {
            DateTime day = new DateTime(startDate.Year, 1, 1).AddDays(j - 1);

            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                businessDays--;
            }
        }

        for (int i = 0; i < holidays.Length; i++)
        {
            if (holidays[i] >= startDate && holidays[i] <= endDate)
            {
                businessDays--;
            }
        }

        return businessDays;
    }


    //Second way
    //
    //static void Main()
    //{
    //    //randomly chosen dates as if they are holidays
    //    DateTime[] holidays = { new DateTime( 2013, 5, 6), new DateTime(2013, 9, 6), new DateTime (2013, 12, 24), new DateTime(2013, 12,24),
    //                            new DateTime(2013, 9,22), new DateTime(2013, 11, 1), new DateTime (2013, 12,26), new DateTime (2013, 12, 31)};

    //    Console.WriteLine("Input DATE, MONTH and YEAR: ");
    //    int date = int.Parse(Console.ReadLine());
    //    int month = int.Parse(Console.ReadLine());
    //    int year = int.Parse(Console.ReadLine());

    //    DateTime endDate = new DateTime(year, month, date);
    //    Console.WriteLine(BusinessDaysUntil(DateTime.Now, endDate, holidays));
    // }

    //static int BusinessDaysUntil(this DateTime firstDay, DateTime lastDay, params DateTime[] holidays)
    //{
    //    firstDay = firstDay.Date;
    //    lastDay = lastDay.Date;
    //    if (firstDay > lastDay)
    //        throw new ArgumentException("Incorrect last day " + lastDay);

    //    TimeSpan span = lastDay - firstDay;
    //    int businessDays = span.Days;
    //    int fullWeekCount = businessDays / 7;
    //    // find out if there are weekends during the time exceedng the full weeks
    //    if (businessDays > fullWeekCount * 7)
    //    {
    //        // we are here to find out if there is a 1-day or 2-days weekend
    //        // in the time interval remaining after subtracting the complete weeks
    //        int firstDayOfWeek = (int)firstDay.DayOfWeek;
    //        int lastDayOfWeek = (int)lastDay.DayOfWeek;
    //        if (lastDayOfWeek < firstDayOfWeek)
    //            lastDayOfWeek += 7;
    //        if (firstDayOfWeek <= 6)
    //        {
    //            if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
    //                businessDays -= 2;
    //            else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
    //                businessDays -= 1;
    //        }
    //        else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
    //            businessDays -= 1;
    //    }

    //    // subtract the weekends during the full weeks in the interval
    //    businessDays -= fullWeekCount + fullWeekCount;

    //    // subtract the number of bank holidays during the time interval
    //    foreach (DateTime bankHoliday in holidays)
    //    {
    //        DateTime bh = bankHoliday.Date;
    //        if (firstDay <= bh && bh <= lastDay)
    //            --businessDays;
    //    }

    //    return businessDays;
    //}
}