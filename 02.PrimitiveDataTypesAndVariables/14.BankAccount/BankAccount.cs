/*A bank account has a holder name
 * (first name, middle name and last name),
 * available amount of money (balance), 
 * bank name, IBAN, BIC code and 3 credit card 
 * numbers associated with the account. 
 * Declare the variables needed to keep the information
 * for a single bank account using the appropriate data 
 * types and descriptive names.
*/


using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Petur";
        string middleName = "Petrov";
        string lastName = "Petkov";
        decimal balance = 4561;
        string bankName = "Unicredit";
        string iban = "BGUNCR798479887933478";
        string bic = "BGSFUNCR";
        ulong creditCardNumberOne = 9445646554645645654;
        ulong creditCardNumberTwo = 6464654488979798798;
        ulong creditCardNumberThree = 8997578798897979575;
    }
}

