using System;

class NameMethod
{
    static void GetName()
    {
        Console.WriteLine("Your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        GetName();
    }
}
