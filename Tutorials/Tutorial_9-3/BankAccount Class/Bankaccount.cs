using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Class
{
    class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal startingBalance)
        {
            balance = startingBalance;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw (decimal amount)
        {
            balance -= amount;
        }
    }
}
