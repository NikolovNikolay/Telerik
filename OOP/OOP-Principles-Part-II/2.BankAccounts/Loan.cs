using System;
using System.Linq;

namespace _2.BankAccounts
{
    public class Loan : Account,IDepositable
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == Customer.Company && months >= 2)
            {
                return (this.Balance * (this.InterestRate / 100) *(months - 2));
            }
            else if(this.Customer == Customer.Company && months < 2)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }
            else if (this.Customer == Customer.Individual && months >= 3)
            {
                return (this.Balance * (this.InterestRate / 100) * (months - 3));
            }
            else if (this.Customer == Customer.Individual && months < 3)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }

            return 0;
        }

        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
