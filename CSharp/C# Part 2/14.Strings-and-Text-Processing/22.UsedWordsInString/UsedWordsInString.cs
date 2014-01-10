/*Write a program that reads a string from the
 * console and lists all different words in the
 * string along with information how many times 
 * each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UsedWordsInString
{
    static void Main()
    {
        string text = "And that is what you do... it weights a lot physically, and mentally it is a lot. Then all sorts of evasive actions or displacement activities kick in: you  go to the fridge, you watch TV, you txt msg friends and finally you sit down with the tome. What happens?";
        string textCopy = text.ToLower();
        int wordCount = 1;

        int index = 0;
        List<string> words = new List<string>();
        StringBuilder sb = new StringBuilder();

        while (index < text.Length)
        {
            string formedWord = "";
            

            if (textCopy[index] != ' ' && textCopy[index] != '.' && textCopy[index] != ',' && textCopy[index] != ':' && textCopy[index] != '?')
            {
                sb.Append(textCopy[index]);
            }
            else
            {
                formedWord = sb.ToString();
                sb.Clear();
            }

            if(formedWord != "")
                words.Add(formedWord);
            index++;

        }
        List<string> usedWords = new List<string>();
        for (int i = 0; i < words.Count; i++)
        {
            for (int j = i + 1; j < words.Count - 1; j++)
            {
                if (usedWords.Contains(words[i]))
                {
                    break;
                }
                if (words[i] == words[j])
                {
                    wordCount++;
                }
            }
            if (!usedWords.Contains(words[i]))
            {
                usedWords.Add(words[i]);

                Console.WriteLine("\"{0}\"    used: {1} time(s)", words[i], wordCount);
                wordCount = 1; 
            }
        }
    }
}
