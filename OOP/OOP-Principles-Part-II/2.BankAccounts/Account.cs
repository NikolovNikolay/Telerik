using System;
using System.Linq;

namespace _2.BankAccounts
{
    public abstract class Account : IDepositable,IWithdrawable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            if (this.balance >= 0 && this.interestRate >= 0)
            {
                this.balance = balance;
                this.interestRate = interestRate;
            }
            else
            {
                throw new ArgumentException("Balance and interest rate can't be negative.");
            }
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value >= 0)
                    this.balance = value;
                else
                    throw new ArgumentException("Balance can't be negative.");
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value >= 0)
                    this.interestRate = value;
                else
                    throw new ArgumentException("Interest rate can't be negative.");
            }
        }

        public abstract decimal GetInterestAmount(int months);

        public virtual void WithdrawMoney(decimal sum)
        {
            Console.WriteLine();
        }
        public virtual void DepositMoney(decimal sum)
        {
            Console.WriteLine();
        }
    }
}
