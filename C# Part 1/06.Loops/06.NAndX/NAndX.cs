/*Write a program that, for a given 
 * two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
*/

using System;

class NAndX
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        Console.Write("Input N= ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Input X= ");
        int x = Int32.Parse(Console.ReadLine());
        double power=1;
        double powered = 1;
        
        decimal faktorial= 1;
        decimal totalSum = 1;
       
        Console.Write("S = 1 + 1!/X + 2!/X^2 + … + N!/X^N = 1 + ");

        for (decimal i = 1; i<= n  ; i++)
        {
            faktorial *= i;
            powered = Math.Pow(x,power);
            decimal poweredTodecimal = Convert.ToDecimal(powered);
            
            if (i == n)
            {
                Console.Write("{0}/{1} = ", faktorial, powered);
            }
            else
            {
                Console.Write("{0}/{1} + ", faktorial, powered);
            }
            totalSum += faktorial / poweredTodecimal;
            power++;
        }
        Console.Write("{0} ",totalSum);
    }
}