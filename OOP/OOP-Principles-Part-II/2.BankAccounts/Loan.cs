using System;
using System.Linq;

namespace _2.BankAccounts
{
    public class Loan : Account,IDepositable
    {
        public Loan(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            if (this.InterestRate <= 0 || this.Balance <= 0)
            {
                throw new ArgumentException("Balance and interest rate must be greater than zero.");
            }
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == CustomerType.Company && months >= 2)
            {
                return (this.Balance * (this.InterestRate / 100) *(months - 2));
            }
            else if(this.Customer == CustomerType.Company && months < 2)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }
            else if (this.Customer == CustomerType.Individual && months >= 3)
            {
                return (this.Balance * (this.InterestRate / 100) * (months - 3));
            }
            else if (this.Customer == CustomerType.Individual && months < 3)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }

            return 0;
        }

        public override void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }

        public override void WithdrawMoney(decimal sum)
        {
            try
            {
                throw new InvalidOperationException("Loan and mortage accounts can not withdraw funds");
            }
            catch (InvalidOperationException exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
