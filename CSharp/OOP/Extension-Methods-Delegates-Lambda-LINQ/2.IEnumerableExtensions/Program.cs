/* 2. Implement a set of extension methods for IEnumerable<T>
 *    that implement the following group functions: sum, product,
 *    min, max, average.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableExtensions
{
    class Program
    {
        static void Main()
        {
            List<double> list = new List<double>();

            list.Add(13);
            list.Add(1313);
            list.Add(34);
            list.Add(93849);
            list.Add(-1);

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
        }
    }
}
