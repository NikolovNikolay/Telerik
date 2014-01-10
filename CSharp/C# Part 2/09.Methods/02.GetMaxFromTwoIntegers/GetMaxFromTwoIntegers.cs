/*Write a method GetMax() with two parameters
 * that returns the bigger of two integers.
 * Write a program that reads 3 integers from 
 * the console and prints the biggest of them 
 * using the method GetMax().
*/

using System;

class GetMaxFromTwoIntegers
{
    static int GetMax(int a, int b)
    {
       int bigger = a;
       if (a < b)
           bigger = b;

       return bigger;
    }

    static void Main()
    {
        Console.WriteLine("Input three numbers: ");
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        Console.WriteLine("Biggest number is: {0}", GetMax(numOne,GetMax(numTwo,numThree)));
    }
}
