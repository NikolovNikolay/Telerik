using System;
using System.Linq;

namespace _2.BankAccounts
{
    public class Mortage : Account, IDepositable
    {
        public Mortage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual && months > 6)
            {
                return (this.Balance * (this.InterestRate / 100) * (months - 6));
            }
            else if (this.Customer == Customer.Individual && months <= 6)
            {
                return (this.Balance * (this.InterestRate / 100) * months);
            }
            else if (this.Customer == Customer.Company && months > 12)
            {
                return ((this.Balance * ((this.InterestRate /100) / 2) * 12) + this.Balance * (this.InterestRate/100) * (months - 12));
            }
            else if (this.Customer == Customer.Company && months <= 12)
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
