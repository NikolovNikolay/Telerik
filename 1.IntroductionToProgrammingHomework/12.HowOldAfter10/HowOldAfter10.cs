using System;

class HowOldAfter10
{
    static void Main()
    {
        DateTime baseDate = DateTime.Now;
        Console.WriteLine("Today we are "+ DateTime.Now);

        Console.Write("Enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        int ageAfter10 = (age+10);

        Console.WriteLine();
        Console.WriteLine("In {0} you will be {1} years old!",baseDate.AddYears(10), ageAfter10);
      //Console.WriteLine("You will be {0} years old after 10 years!", ageAfter10);
    }
}

