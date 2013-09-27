/* 6.Write a program that prints from given array of integers all
 *   numbers that are divisible by 7 and 3. Use the built-in extension
 *   methods and lambda expressions. Rewrite the same with LINQ.
*/

using System;
using System.Collections;
using System.Linq;

namespace _6.DivisibleBy7and3
{
    class Program
    {
        static void Main()
        {
            int[] arrayOfIntegers = new int[] { 1, 4, 7, 3, 0, 21, 56, 42, 67, 84 };

            var divisibleDigitsOne = arrayOfIntegers.Where(d => (d % 3 == 0) && (d % 7 == 0) && (d != 0));

            PrintDivisibleDigits(divisibleDigitsOne);
            Console.WriteLine();

            var divisibleDigitsTwo =
                from number in arrayOfIntegers
                where number % 3 == 0 && number % 7 == 0 && number != 0
                select number;

            PrintDivisibleDigits(divisibleDigitsTwo);
        }


        private static void PrintDivisibleDigits(IEnumerable array)
        {
            foreach (var number in array)
            {
                Console.Write("{0} ",number);
            }
        }
    }
}
