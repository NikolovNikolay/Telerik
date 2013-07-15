using System;
using System.Text;

class EncodingDecodingOfAMessage
{
    static void Main()
    {
        string message = "More than 2,400 UK-based bankers are paid more than €1 million, 14 times as many as in Germany and 15 times as many as in France, according to figures published today. There were 739 bankers across the EU paid more than €1 million in 2011, meaning that Britain’s total is more than three times that number. The data from the European Banking Authority, the pan-European regulator, shows how new rules on bankers’ pay will affect Britain far more than other EU nations. Bonuses among the top-paid echelon in the UK were 346 per cent of base pay in 2011, down from 611 per cent in 2010. New rules EU rules coming in next year are set to cap bonuses at 100 per cent of base pay, or 200 per cent with the explicit approval of shareholders. Of the 2,436 UK based bankers on more than €1 million in 2011, 1,809 were…";
        string key = "banking";

        Console.WriteLine(Encrypt(message, key));
        Console.WriteLine();
        Console.WriteLine(Decrypt(Encrypt(message, key), key));
    }

    static string Encrypt(string message, string key)
    {
        int length = message.Length;
        StringBuilder encription = new StringBuilder(length);

        StringBuilder cipher = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            cipher.Append(key);
        }

        for (int i = 0; i < length; i++)
        {
            encription.Append((char)(message[i] ^ cipher[i]));
        }

        string result = encription.ToString();

        return result;
    }

    static string Decrypt(string message, string key)
    {
        string result = Encrypt(message, key);

        return result;
    }
}
