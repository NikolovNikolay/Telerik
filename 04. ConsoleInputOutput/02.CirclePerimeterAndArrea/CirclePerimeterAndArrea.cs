/*Write a program that reads the radius r
 * of a circle and prints its perimeter and area.
*/

using System;

class CirclePerimeterAndArrea
{
    static void Main()
    {
        Console.Write("Inpit circle's radius: ");
        double circleRadius = double.Parse(Console.ReadLine());
        double cirlcePerimeter = Math.PI * circleRadius * 2;
        double circleArea = (circleRadius * circleRadius) * Math.PI;
        Console.WriteLine();
        Console.WriteLine("The circle's perimeter is {0}", cirlcePerimeter);
        Console.WriteLine("The circle's area is {0}",circleArea);
    }
}
