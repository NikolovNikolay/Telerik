/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings. */


using System;

class QuotedStrings
{
    static void Main()
    {
        string escapeCode = "The \"use\" of quotations causes difficulties.";
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("Print string using escape character: {0}", escapeCode);
        Console.WriteLine("Print string using quoted string: {0}", quotedString);
    }
}

