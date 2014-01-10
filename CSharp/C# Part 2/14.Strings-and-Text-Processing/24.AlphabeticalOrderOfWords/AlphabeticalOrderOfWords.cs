/*Write a program that reads a list 
 * of words, separated by spaces and 
 * prints the list in an alphabetical order.
*/

using System;

class AlphabeticalOrderOfWords
{
    static void Main()
    {
        string str = "spirit wisdom query ajax center blur power gasp";
        Console.WriteLine(str);
        Console.WriteLine();
        string[] words = str.Split(' ');
        Array.Sort(words);

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
