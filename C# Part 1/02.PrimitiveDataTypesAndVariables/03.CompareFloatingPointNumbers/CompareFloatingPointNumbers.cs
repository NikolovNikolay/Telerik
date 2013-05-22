/*Write a program that safely compares floating-point numbers 
 * with precision of 0.000001. Examples:(5.3 ; 6.01)  false;
 * (5.00000001 ; 5.00000003)  true */


using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers of type decimal (with floating point)");
        Console.Write("First number: ");
        decimal firstDecimal = decimal.Parse(Console.ReadLine());
        decimal firstNumberRounded = Math.Round(firstDecimal, 6);
        Console.WriteLine("Rounded first number: {0}", firstNumberRounded);
        Console.WriteLine();
        Console.Write("Second number: ");
        decimal secondDecimal = decimal.Parse(Console.ReadLine());
        decimal secondNumberRounded = Math.Round(secondDecimal, 6);
        Console.WriteLine("Rounded second number: {0}", secondNumberRounded);
        bool comparison = true;
        if (firstNumberRounded > secondNumberRounded)
        {
            comparison = true;
        }
        if (firstNumberRounded == secondNumberRounded)
        {
            Console.WriteLine("The numbers are equal");
        }
        if(firstNumberRounded<secondNumberRounded)
        {
            comparison = false;
        }
        Console.WriteLine("First number is bigger than the second: {0}", comparison);
    }
}