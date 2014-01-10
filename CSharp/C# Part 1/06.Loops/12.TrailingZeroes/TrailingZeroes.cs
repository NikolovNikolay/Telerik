/* Write a program that calculates
 * for given N how many trailing zeros 
 * present at the end of the number N!*/

using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Enter number N = ");
        int n = Int32.Parse(Console.ReadLine());
        double sum = 0;
        BigInteger faktorial = 1;
       
        for (int i = 1; i <= n; i++)
        {
            faktorial *= i;
        }
        Console.WriteLine("{1}! = {0} ", faktorial, n);
        for (int j = 1; j < n; j++)
        {
                double power = Math.Pow(5, j); //Math.Pow uses only double
                int powerToInt = Convert.ToInt32(power); // We convert the double to int to avoid the marks after
                                                         // the floating point in sum variable
                if (powerToInt > n)
                {
                    break;
                }
                sum += (n / powerToInt);
        }
        Console.WriteLine("The trailing zeroes = {0} ",sum);
    }
}

