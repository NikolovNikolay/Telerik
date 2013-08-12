/*You are given a sequence of positive integer
 * values written into a string, separated by 
 * spaces. Write a function that reads these values
 * from given string and calculates their sum.*/

using System;

class SumOfStringElements
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by spaces: ");
        string str = Console.ReadLine();
        int sum = 0;
        string number = "";

        Console.Write("Result = {0}",GetValuesFromString(str, sum, number));
        Console.WriteLine();
    }

    static int GetValuesFromString(string str, int sum, string number)
    {
        for (int i = 0; i < str.Length; i++)
        {

            if (str[i] != ' ')
            {
                number = number + str[i];
            }

            if (str[i] == ' ' || i == str.Length - 1)
            {
                int strToInt = Convert.ToInt32(number);
                sum = sum + strToInt;
                number = "";
            }
        }
        return sum;
    }
}
