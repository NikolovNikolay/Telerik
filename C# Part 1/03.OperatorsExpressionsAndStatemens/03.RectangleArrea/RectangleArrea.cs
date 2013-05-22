/*Write an expression that calculates
 * rectangle’s area by given width and height.
*/

using System;

class RectangleArrea
{
    static void Main()
    {
        Console.Write("Input rectangle's width: ");
        int rectangleWidth = Int32.Parse(Console.ReadLine());
        Console.Write("Input rectangle's height: ");
        int rectangleHeight = Int32.Parse(Console.ReadLine());

        int rectangleArrea = rectangleHeight * rectangleWidth;
        Console.WriteLine("The rectangle's arrea is {0}", rectangleArrea);
    }
}

