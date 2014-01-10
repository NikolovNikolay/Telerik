/*Write an expression that checks
 * if given point (x,  y) is within
 * a circle K(O, 5).
*/

using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Input coordinate X: ");
        double coordinateX = double.Parse(Console.ReadLine());

        Console.Write("Input coordinate Y: ");
        double coordinateY = double.Parse(Console.ReadLine());

        bool pointIsInCircle = false;
        double proofExpression = Math.Sqrt((coordinateX * coordinateX) + (coordinateY + coordinateY));

        Console.Write("The point is in the circle: ");
        Console.WriteLine(proofExpression< 5 ? pointIsInCircle = true : pointIsInCircle = false);
        Console.WriteLine();
    }
}
