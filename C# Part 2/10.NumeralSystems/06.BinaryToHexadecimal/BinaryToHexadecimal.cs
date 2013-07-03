using System;
using System.Numerics;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Input number in binary formation: ");
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        string result = "";
        int power = 0;
        //string numberToString = number.ToString();
        

        while (true)
        {
            if (number > 0)
            {
                BigInteger remainderInBinary = (BigInteger) number % 10000;
                number /= 10000;
                int sum = 0;
                for (int i = 1; i <= 4; i++)
                {
                    
                    BigInteger currentRemainder = (BigInteger)remainderInBinary % 10;
                    remainderInBinary /= 10;
                    sum = sum + (int)currentRemainder * (int)Math.Pow(2, power);
                    power++; 
                }
                if (sum <= 9)
                {
                    result = sum + result;
                }
                else
                {
                    if (sum == 10) result = "A" + result;
                    if (sum == 11) result = "B" + result;
                    if (sum == 12) result = "C" + result;
                    if (sum == 13) result = "D" + result;
                    if (sum == 14) result = "E" + result;
                    if (sum == 15) result = "F" + result;
                }
                power = 0;

            }
            else
            {
                break;
            }

        }

        Console.WriteLine(result);
    }
}
