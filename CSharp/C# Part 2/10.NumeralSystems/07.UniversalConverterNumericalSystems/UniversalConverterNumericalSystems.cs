using System;
using System.Numerics;

class UniversalConverterNumericalSystems
{
    static void Main()
    {
        Console.Write("Convert from: ");
        int s = int.Parse(Console.ReadLine());
        
        Console.Write("Convert to: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Input number in {0}-based numerical system: ",s);
        BigInteger numberS = BigInteger.Parse(Console.ReadLine());

        int power = 0;
        BigInteger toDecimal = 0;

        string numberSToString = numberS.ToString();

        for (int i = 0; i < numberSToString.Length; i++)
        {
            BigInteger lastDigit = numberS % 10;
            toDecimal = toDecimal + lastDigit * (int)Math.Pow(s, power);
            power++;
            numberS /= 10;
        }

        string resultInD = "";

        while (true)
        {
            if (toDecimal > 0)
            {
                int remainder = (int)toDecimal % d;
                if (d == 16 && (remainder == 10 || remainder == 11 || remainder == 12 || remainder == 13 || remainder == 14 || remainder == 15))
                {
                    if (remainder == 10) resultInD = "A" + resultInD;
                    if (remainder == 11) resultInD = "B" + resultInD;
                    if (remainder == 12) resultInD = "C" + resultInD;
                    if (remainder == 13) resultInD = "D" + resultInD;
                    if (remainder == 14) resultInD = "E" + resultInD;
                    if (remainder == 15) resultInD = "F" + resultInD;
                }
                else
                {
                    resultInD = remainder + resultInD;
                }
                toDecimal /= d;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Result in {0}-based numerical system is: {1}",d,resultInD);
    }
}
