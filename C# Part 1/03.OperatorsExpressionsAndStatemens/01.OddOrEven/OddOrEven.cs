/*Write an expression that checks
 * if given integer is odd or even.
*/

using System;

class OddOrEven
{
    static void Main()
    {
        
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        // First method
        Console.WriteLine(number % 2 == 0 ? "The number is even" : "The number is odd");

        // Second method
        //if (number % 2 == 0)
        //{
        //    Console.WriteLine("The number is even");
        //}
        //else
        //{
        //    Console.WriteLine("The number is odd");
        //}

        // Third method
        //if ((number & 1) == 0)
        //{
        //    Console.WriteLine("The number is even");
        //}
        //if ((number & 1) == 1)
        //{
        //    Console.WriteLine("The number is odd");
        //}
    }
}
