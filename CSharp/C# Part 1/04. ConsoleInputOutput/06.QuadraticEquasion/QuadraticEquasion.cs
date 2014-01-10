/*Write a program that reads the
 * coefficients a, b and c of a quadratic equation
 * ax2+bx+c=0 and solves it (prints its real roots).
*/

using System;
using System.Text;

class QuadraticEquasion
{
    static void Main()
    {
        Console.WriteLine("Enter a,b and c for the quadratic equation:");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

        /* We can use the charmap to find the code of 2 in superscript, but it doesn't work in my console
           //char superTwo = '\u00B2';
           //Console.WriteLine("The quadratic equation is : {0}X{1}+{2}X+{3}=0", a,superTwo,b,c); */

        Console.WriteLine("The quadratic equation is : {0}X^2+{1}X+{2}=0", a, b, c);
        double discriminant = ((b * b) - (4 * a * c));
        Console.WriteLine("The discriminant is {0}", discriminant);

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots because the descriminan is negative!");
        }
        else
        {
            if (discriminant == 0)
            {
                decimal oneRootOnly = ((b / (2 * a)) * (-1));
                Console.WriteLine("There is only one real root : {0}, because the discriminant is 0", oneRootOnly);
            }
            else
            {
                double firstRoot = (((-1) * b) + Math.Sqrt(discriminant)) / (2 * a);
                double secondRoot = (((-1) * b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("There are two real roots: {0} and {1}", firstRoot, secondRoot);
            }
        }
    }
}
