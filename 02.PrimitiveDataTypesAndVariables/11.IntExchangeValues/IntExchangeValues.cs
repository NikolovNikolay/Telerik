/*Declare  two integer variables and assign 
 * them with 5 and 10 and after that exchange their values.
*/

using System;

class IntExchangeValues
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        int thirdInt;
        Console.WriteLine(firstInt);
        Console.WriteLine(secondInt);

        thirdInt = secondInt;
        secondInt = firstInt;
        firstInt = thirdInt;

        Console.WriteLine("Exchanged");
        Console.WriteLine(firstInt);
        Console.WriteLine(secondInt);
    }
}
