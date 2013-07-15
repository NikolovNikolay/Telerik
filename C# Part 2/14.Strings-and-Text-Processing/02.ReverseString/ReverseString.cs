using System;
using System.Text;

class ReverseString
{
    static string ReversingString(StringBuilder sb, string str)
    {
        string result = null;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }

        result = sb.ToString();

        return result;
    }

    static void Main()
    {
        string str = "This is some sample text here";
        StringBuilder sb = new StringBuilder(str.Length);

        Console.WriteLine(ReversingString(sb, str));
    }
}
