/*Write an expression that checks for
 * given point (x, y) if it is within the
 * circle K( (1,1), 3) and out of the 
 * rectangle R(top=1, left=-1, width=6, height=2).
*/

using System;

class PointInCircleAndRectangle
{
    static void Main()
    {
        Console.Write("Input coordinate X: ");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.Write("Input coordinate Y: ");
        double coordinateY = double.Parse(Console.ReadLine());

        bool poinIsInCircleAndRectangle = false;
        double proofExpressionCircle = Math.Sqrt((coordinateX*coordinateX) + (coordinateY*coordinateY));
        Console.Write("Point is in the circle, but outside the rectangle: ");
        Console.Write(!((coordinateX > -1 && coordinateX < 5) && (coordinateY > -1 && coordinateY < 1)) && proofExpressionCircle < 4 ? 
                                                                poinIsInCircleAndRectangle = true : poinIsInCircleAndRectangle = false);
        Console.WriteLine();
    }
}
