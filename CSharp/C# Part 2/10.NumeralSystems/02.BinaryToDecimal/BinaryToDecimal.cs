using System;
using System.Numerics;

class BinaryToDecimal
{
    static void Main()
    {
        int power = 0;
        Console.Write("Input binary number: ");
        BigInteger binaryNumber = BigInteger.Parse(Console.ReadLine());
        int digitInDecimal = 0;

        string numberToString = binaryNumber.ToString();

        for (int i = 0; i < numberToString.Length; i++)
        {
            BigInteger remainder = (BigInteger)binaryNumber % 10;
            digitInDecimal = (int)(digitInDecimal + remainder*((int)Math.Pow(2,power)));
            binaryNumber /= 10;
            power++;
        }

        Console.WriteLine(digitInDecimal);
    }
}
