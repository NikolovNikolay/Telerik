using System;
using System.Linq;

namespace _2.BankAccounts
{
    public interface IDepositable
    {
        void DepositMoney(decimal sum);
    }
}
