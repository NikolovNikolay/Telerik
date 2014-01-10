/*Write a program that reverses the words in given sentence.
*/

using System;

class ReverseWordsInSentance
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        //string text = Console.ReadLine();

        

        string[] words = text.Split(' ');
        Array.Reverse(words);

        Console.WriteLine(string.Join(" ",words));
    }

   
}
