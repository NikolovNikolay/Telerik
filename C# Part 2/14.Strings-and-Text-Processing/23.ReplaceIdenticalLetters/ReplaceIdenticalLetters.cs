/*Write a program that reads a string from 
 * the console and replaces all series of
 * consecutive identical letters with a 
 * single one. 
 * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
*/

using System;
using System.Linq;


    class ReplaceIdenticalLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa ii oo aallabala pp";
            int index = 0;
            int identicalCount = 0;

            while (index < text.Length - 1)
            {
                if (text[index] == text[index + 1])
                {
                    identicalCount++;
                }
                else
                {
                    text = text.Remove((index - identicalCount + 1), identicalCount);
                    index -= identicalCount;
                    identicalCount = 0;
                }
                index++;
            }
            if (text[text.Length - 1] == text[text.Length - 2])
                text = text.Remove(text.Length - 1);

            Console.WriteLine(text);
        }
    }
