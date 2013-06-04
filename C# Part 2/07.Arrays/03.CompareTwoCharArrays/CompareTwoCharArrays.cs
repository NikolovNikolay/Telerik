/*Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.Write("How many letters wolud you like to compare? ");
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        char[] secondArray = new char[n];

        Console.WriteLine("Enter letters for first array");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Enter value for index {0}: ", i );
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine(" Enter letters for second array");
        for (int j = 0; j < n; j++)
        {
            Console.Write("Enter value for index {0}: ", j);
            secondArray[j] = char.Parse(Console.ReadLine());
        }
        for (int k = 0; k < n; k++)
        {
            int compare = firstArray[k].CompareTo(secondArray[k]);

            if (compare > 0)
            {
                Console.WriteLine("\'{0}\' comes earlier than \'{1}\' in alphabetical order", secondArray[k], firstArray[k]);
            }
            else if (compare < 0)
            {
                Console.WriteLine("\'{0}\' comes earlier than \'{1}\' in alphabetical order", firstArray[k], secondArray[k]);
            }
            else
            {
                Console.WriteLine("The two letters are equal");
            }
        }
    }
}

