/*2. A bank holds different types of accounts for its customers: deposit accounts,
 * loan accounts and mortgage accounts. Customers could be individuals or companies.
	All accounts have customer, balance and interest rate (monthly based). Deposit 
 * accounts are allowed to deposit and with draw money. Loan and mortgage accounts 
 * can only deposit money. All accounts can calculate their interest amount for a 
 * given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
    Loan accounts have no interest for the first 3 months if are held by individuals 
 * and for the first 2 months if are held by a company. Deposit accounts have no interest
 * if their balance is positive and less than 1000. Mortgage accounts have ½ interest 
 * for the first 12 months for companies and no interest for the first 6 months for individuals.
    Your task is to write a program to model the bank system by classes and interfaces. 
 * You should identify the classes, interfaces, base classes and abstract actions and 
 * implement the calculation of the interest functionality through overridden methods.
*/

using System;
using System.Linq;

namespace _2.BankAccounts
{
    class Program
    {
        static void Main()
        {
            try
            {
                Account companyDeposit = new Deposit(CustomerType.Company, 1000m, 0.67m);
                companyDeposit.DepositMoney(10000m);
                companyDeposit.WithdrawMoney(7578m);
                Console.WriteLine(companyDeposit.GetInterestAmount(48));
                companyDeposit.WithdrawMoney(20000000m);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }

                Console.WriteLine("--------------------");

            try 
	        {	        
		        Account individualsMortage = new Mortage(CustomerType.Individual, 780000m, 0.47m);
                Console.WriteLine(individualsMortage.GetInterestAmount(240));

	        }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);                
            }
        }
    }
}
