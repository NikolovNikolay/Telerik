/*A marketing firm wants to keep record
 * of its employees. Each record would have
 * the following characteristics – first name,
 * family name, age, gender (m or f), ID number,
 * unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information 
 * for a single employee using appropriate data types and 
 * descriptive names.
*/

using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName = "Georgi";
        string familyName = "Georgiev";
        byte age = 38;
        char gender = 'm';
        int idNumber = 123456789;
        int UniqueEmployeeNumber = 27564568;

        Console.WriteLine("First name: {0}",firstName);
        Console.WriteLine("Last name: {0}",familyName);
        Console.WriteLine("Age: {0}",age);
        Console.WriteLine("Gender: {0}",gender);
        Console.WriteLine("ID Number: {0}",idNumber);
        Console.WriteLine("Unique Number: {0}",UniqueEmployeeNumber);
    }
}

