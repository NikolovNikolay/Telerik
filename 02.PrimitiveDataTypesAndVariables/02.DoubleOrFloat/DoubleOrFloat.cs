/*Which of the following values can be assigned to a variable 
 * of type float and which to a variable
 * of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
*/

using System;

class DoubleOrFloat
{
    static void Main()
    {
        // If the number we would like to declare has more than 7 marks after the floating point, it should be type double.
        // If the number has <= than 7 marks after the floating point, it should be float, followed by the suffix f.
        double firstVariable = 34.567839023;
        float secondVariable= 12.345f;
        double thirdVariable= 8923.1234857;
        float fourthVariable = 3456.091f;
    }
}

