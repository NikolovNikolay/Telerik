/*Create a program that assigns null
 * values to an integer and to double variables. 
 * Try to print them on the console, try to add 
 * some values or the null literal to them and see the result.
*/

using System;

class NullValueToInt
{
    static void Main()
    {
        int? intNullValue = null;
        double? doubleNullValue = null;

        Console.WriteLine("Int null value: "+intNullValue);
        Console.WriteLine("Double null value: "+doubleNullValue);
        Console.WriteLine("Int null value + double null value: "+intNullValue+doubleNullValue);
        Console.WriteLine("Int null value + 1000: "+intNullValue+987);
        intNullValue = 897;
        Console.WriteLine("intNullValue = "+intNullValue);
        Console.WriteLine("Double null value + 1000: "+doubleNullValue+1000);
        Console.WriteLine("doubleNullValue = "+doubleNullValue);
    }
}
