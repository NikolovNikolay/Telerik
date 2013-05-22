/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. Write a program that reads the 
 * information about a company and its manager and prints them on the console*/

using System;

class CompanyAndManger
{
    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 26;
        //Company info
        Console.WriteLine("Enter company name, address, phone, fax, website, manager");
        string cName = Console.ReadLine();
        string cAddress = Console.ReadLine();
        string cPhone = Console.ReadLine();
        string cFax = Console.ReadLine();
        string cWebSite = Console.ReadLine();
        string cManager = Console.ReadLine();
        //Manager info
        Console.WriteLine("Enter manager first name, last name, age, phone");
        string mFirstName = Console.ReadLine();
        string mLastName = Console.ReadLine();
        string mAge = Console.ReadLine();
        string mPhone = Console.ReadLine();
        Console.WriteLine("  Company info: ");
        Console.WriteLine(@"Name: {0}
Adress: {1}
Phone number: {2}
Fax number: {3}
Web Site: {4}
Manager: {5}", cName, cAddress, cPhone,cFax,cWebSite,cManager);
        Console.WriteLine();
        
        Console.WriteLine("  Manager info: ");
        Console.WriteLine(@"First name: {0}
Last name: {1}
Age: {2}
Phone number: {3}", mFirstName,mLastName,mAge,mPhone);
    }
}

