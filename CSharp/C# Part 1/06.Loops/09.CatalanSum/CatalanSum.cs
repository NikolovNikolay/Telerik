/*In the combinatorial mathematics,
 * the Catalan numbers are calculated 
 * by the following formula:
 * (2n)! / (n+1)!n!
*/

using System;

class CatalanSum
{
    static void Main()
    {
        Console.Write("Input n = ");
        int n = Int32.Parse(Console.ReadLine());
        decimal sumOne = 1, sumTwo = 1, sumThree = 1;
        if (n > 0)
        {
            for (int i = 1; i <= (2 * n); i++)
            {
                sumOne *= i;
            }
            for (int j = 1; j <= (n + 1); j++)
            {
                sumTwo *= j;
            }
            for (int k = 1; k <= n; k++)
            {
                sumThree *= k;
            }
            Console.Write("(2n)!/(n+1)!n! = {0}/{1}*{2} = {3} ", sumOne, sumTwo, sumThree, sumOne / (sumTwo * sumThree));
        }
        else
        {
            Console.WriteLine("Enter a valid number!");
        }
    }
}

