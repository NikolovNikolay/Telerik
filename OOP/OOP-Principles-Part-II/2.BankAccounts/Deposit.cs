using System;
using System.Linq;

namespace _2.BankAccounts
{
    public class Deposit : Account,IWithdrawable,IDepositable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }

        public override void WithdrawMoney(decimal sum)
        {
            try
            {
                this.Balance -= sum;
            }
            catch (Exception exc)
            {
                Console.WriteLine(" Insuficient funds." +" "+exc.Message);
            }
            
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return (this.Balance*((this.InterestRate / 100) * months));
            }
        }
    }
}
