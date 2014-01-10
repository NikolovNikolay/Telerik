/*Write a program that calculates 
 * N!*K! / (K-N)! for given N and K (1<N<K).
*/

using System;

class NKFaktorialHarder
{
    static void Main()
    {
        Console.WriteLine("Please enter N and K for (1<N<K)");
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K= ");
        int k = int.Parse(Console.ReadLine());

        decimal nFaktorial = 1;
        decimal kFaktorial = 1;
       
        if (n > 1 && k > n)
        {
            for (int i = 1; i <= n; i++)
            {
                nFaktorial *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                kFaktorial *= j;
            }
            Console.WriteLine("N!*K!/(K-N) = {0}/{1} = {2} ", (nFaktorial * kFaktorial), (k - n), ((nFaktorial * kFaktorial) / (k - n)));
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Enter valid numbers");
        }
    }
}

