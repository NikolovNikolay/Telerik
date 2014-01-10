/*Write an expression that calculates
 * trapezoid's area by given sides a and b and height h.
*/
using System;

class TrapezoidArrea
{
    static void Main()
    {
        Console.WriteLine("Input side a, side b and height: ");
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = Double.Parse(Console.ReadLine());
        double trapezoidArrea = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The trapezoid's arrea is {0}", trapezoidArrea);
    }
}