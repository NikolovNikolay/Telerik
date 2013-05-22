/*Write a program to calculate the sum
 * (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...1/n
*/

using System;

class SumWithPrecision
{
    static void Main()
    {
        Console.Write("Enter \"n\": ");
        decimal n = Decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        Console.WriteLine("The sum of 1+ 1/2 + 1/3 + .... + 1/n is: ");
        for (decimal i = 1; i <= n; i++)
        {
            decimal division = 1 / i;
            sum += division;
        }
        Console.WriteLine(Math.Round(sum, 3));
    }
}
