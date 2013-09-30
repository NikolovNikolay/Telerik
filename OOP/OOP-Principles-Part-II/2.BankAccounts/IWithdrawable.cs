using System;
using System.Linq;

namespace _2.BankAccounts
{
    public interface IWithdrawable
    {
        void WithdrawMoney(decimal sum);
    }
}
