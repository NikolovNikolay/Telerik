/*Write a program that calculates N!/K! for given N and K (1<K<N).
*/

using System;

class NKFaktorial
{
    static void Main()
    {
        Console.WriteLine("Please enter N and K for (1<K<N)");
        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K= ");
        int k = int.Parse(Console.ReadLine());
       
        if (k > 1 && n > k)
        {
            decimal nFaktorial=1;
            decimal kFaktorial=1;

            for (int i = 1; i <= n; i++)
            {
                nFaktorial *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                kFaktorial *= j;
            }
            Console.WriteLine("N!/K! is: {0}", (nFaktorial/ kFaktorial ));
        }
        else
        {
            Console.WriteLine("Please input valid numbers");
        }
    }
}