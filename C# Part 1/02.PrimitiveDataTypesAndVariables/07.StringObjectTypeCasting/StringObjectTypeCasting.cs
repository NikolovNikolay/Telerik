/*Declare two string variables and assign them 
 * with “Hello” and “World”. Declare an object 
 * variable and assign it with the concatenation 
 * of the first two variables (mind adding an interval).
 * Declare a third string variable and initialize it with 
 * the value of the object variable (you should perform type casting).
*/

using System;

class StringObjectTypeCasting
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object firstAndSecondStr = firstString + " " + secondString;
        string typeCast =(string) firstAndSecondStr;
        Console.WriteLine(typeCast);
    }
}

