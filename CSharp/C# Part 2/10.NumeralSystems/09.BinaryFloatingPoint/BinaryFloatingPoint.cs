using System;

class BinaryFloatingPoint
{
    static void Main()
    {
        Console.Write("Input a floating point number: ");
        double number = double.Parse(Console.ReadLine());

        string result = "";

        long doubleToBinary = BitConverter.DoubleToInt64Bits(number);
        for (int i = 0; i < 64; i++)
        {
            long bit = ((doubleToBinary >> i) & 1);
            result = bit + result;
        }
        Console.WriteLine(result);
    }
}
