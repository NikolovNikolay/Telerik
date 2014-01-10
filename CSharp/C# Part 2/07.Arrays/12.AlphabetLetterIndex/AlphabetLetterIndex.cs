/*Write a program that creates an array containing
 * all letters from the alphabet (A-Z). Read a word
 * from the console and print the index of each of its
 * letters in the array.
*/

using System;

class AlphabetLetterIndex
{
    static void Main()
    {
        char[] arrayOfLetters = { ' ','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                  's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        string word = Console.ReadLine();
  
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine(Array.BinarySearch(arrayOfLetters,word[i]));
        }
    }
}
