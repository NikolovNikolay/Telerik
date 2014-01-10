/*Write methods that calculate the
 * surface of a triangle by given:
Side and an altitude to it; Three sides;
 * Two sides and an angle between them. Use System.Math.
*/

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("1) Input side and altitude: ");
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("2) Input three sides: ");
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        Console.WriteLine("3) Input two sides and angle in degrees: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double degrees = double.Parse(Console.ReadLine());

        Console.WriteLine("1) Surface is: {0}", CalculateSurfaceBySideAndAltitude(side, altitude));
        Console.WriteLine("2) Surface is: {0}", CalculateSurfaceByThreeSides(sideA, sideB, sideC));
        Console.WriteLine("3) Surface is: {0:F2}", CalculateSurfaceByTwoSidesAndAngle(a, b, degrees));
    }

    static double CalculateSurfaceBySideAndAltitude(double side, double altitude)
    {
        double surface = 0.5 * side * altitude;
        return surface;
    }

    static double CalculateSurfaceByThreeSides(double a, double b, double c)
    {
        double halfPerimeter = 0.5 * (a + b + c);
        double surface = Math.Sqrt(halfPerimeter*(halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

        return halfPerimeter;
    }

    static double CalculateSurfaceByTwoSidesAndAngle(double a, double b, double degrees)
    {
        double surface = 0.5 * a * b * Math.Sin(ConvertDegreesInRadians(degrees));
        return surface;
    }

    static double ConvertDegreesInRadians(double degrees)
    {
        double radians = Math.PI * degrees / 180.0;
        return radians;
    }
}

