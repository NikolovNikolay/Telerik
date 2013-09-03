/*Write a program to check if in a given 
expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/

using System;

class Brackets
{
    static void Main()
    {
        Console.WriteLine("Enter some expression:");
        //string expression = "))a+b( -c)";
        string expression = Console.ReadLine();

        int brackets = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets++;
            }
            if (expression[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                Console.WriteLine("Error in expression!");
                return;
            }
        }

        if (brackets != 0)
        {
            Console.WriteLine("Error in expression!");
        }
        else
        {
            Console.WriteLine("Expression is correct!");
        }
    }
}
