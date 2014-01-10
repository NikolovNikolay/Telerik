/* 1. Implement an extension method Substring(int index, int length) for the class StringBuilder
 *    that returns new StringBuilder and has the same functionality as Substring in the class String.
*/

using System;
using System.Linq;
using System.Text;

namespace SubstringExtension
{
    class Program
    {
        static void Main()
        {
            var sb = new StringBuilder();

            sb.Append("ala bala portokala");
            
            Console.WriteLine(sb.Substring(5, 1000));
        }
    }
}
