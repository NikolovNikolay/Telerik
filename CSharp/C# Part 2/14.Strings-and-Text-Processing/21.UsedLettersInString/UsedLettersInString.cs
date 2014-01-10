/*Write a program that reads a string from the
 * console and prints all different letters in
 * the string along with information how many
 * times each letter is found. 
*/

using System;
using System.Collections.Generic;
using System.Linq;

class UsedLettersInString
{
    static void Main()
    {
        string text = "And that is what you do... it weights a lot physically, and mentally it is a lot. Then all sorts of evasive actions or displacement activities kick in: you  go to the fridge, you watch TV, you txt msg friends and finally you sit down with the tome. What happens?";
        string textCopy = text.ToLower();

        int index = 0;
        List<char> letters = new List<char>();
        
        while (index <= text.Length - 1)
        {
            int letterCount = 0;
            char letter = textCopy[index];
            if (letters.Contains(letter))
            {
                index++;
                continue;
            }
           
            else 
            {
                if (letter == '.' || letter == ',' || letter == ' ' || letter == ':' || letter == '?')
                {
                    index++;
                    continue;
                }
                else
                {
                    for (int i = 0; i < textCopy.Length; i++)
                    {
                        if (letter == text[i])
                        {
                            letterCount++;
                        }
                    }
                }
                letters.Add(letter);
                Console.WriteLine("\'{0}\' - {1}", letter, letterCount);
            }
            index++;
        }
    }
}
