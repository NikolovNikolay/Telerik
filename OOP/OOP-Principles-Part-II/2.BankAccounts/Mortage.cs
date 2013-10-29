using System;
using System.Linq;

namespace _2.BankAccounts
{
    public class Mortage : Account, IDepositable
    {
        public Mortage(CustomerType customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            if (this.InterestRate <= 0 || this.Balance <= 0)
            {
                throw new ArgumentException("Balance and interest rate must be greater than zero.");
            }
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == CustomerType.Individual && months > 6)
            {
                return (this.Balance * (this.InterestRate / 100) * (months - 6));
            }
            else if (this.Customer == CustomerType.Individual && months <= 6)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }
            else if (this.Customer == CustomerType.Company && months > 12)
            {
                return ((this.Balance * ((this.InterestRate /100) / 2) * 12) + this.Balance * (this.InterestRate/100) * (months - 12));
            }
            else if (this.Customer == CustomerType.Company && months <= 12)
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
