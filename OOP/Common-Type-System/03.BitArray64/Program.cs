﻿/* 5. Define a class BitArray64 to hold 64 bit values inside an
 * ulong value. Implement IEnumerable<int> and Equals(…),
 * GetHashCode(), [], == and !=.
*/

using System;
using System.Linq;

namespace _03.BitArray64
{
    class Program
    {
        static void Main()
        {
            BitArray64 bits = new BitArray64(ulong.Parse(Console.ReadLine()));
            var bitz = bits.Bits;
            Console.WriteLine(bits[63]);

            foreach (var bit in bitz)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            BitArray64 bitss = new BitArray64(ulong.Parse(Console.ReadLine()));

            Console.WriteLine(bits==bitss);
            Console.WriteLine(bitss.GetHashCode());
        }
    }
}
