/*We are given integer number n,
 * value v (v=0 or 1) and a position p.
 * Write a sequence of operators that 
 * modifies n to hold the value v at the
 * position p from the binary representation of n.
*/

using System;

class ModifiyTheValueOfTheBit
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        string numberToBinary = Convert.ToString(number, 2).PadLeft(30, '0');
        Console.WriteLine("---> {0}", numberToBinary);

        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Set bit on position {0} to 0/1? ", p);
        byte value = byte.Parse(Console.ReadLine());

        if (value == 1)
        {
            int mask = 1 << p;
            int maskOrNumber = number | mask;
            string maskOrNumberToBinary = Convert.ToString(maskOrNumber, 2).PadLeft(30, '0');
            Console.WriteLine("The result is: {0} ---> {1}", maskOrNumber, maskOrNumberToBinary);
        }
        if (value == 0)
        {
            int mask = ~(1 << p);
            int maskAndNumber = mask & number;
            string maskAndNumberToBinary = Convert.ToString(maskAndNumber, 2).PadLeft(30, '0');
            Console.WriteLine("The result is: {0} ---> {1}", maskAndNumber, maskAndNumberToBinary);
        }
    }
}

