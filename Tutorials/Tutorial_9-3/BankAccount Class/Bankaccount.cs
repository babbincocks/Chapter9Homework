using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Class
{
    class BankAccount
    {
        //Backing variable that retains the balance of the account.
        private decimal balance;

        //Constructor to set initial value.
        public BankAccount(decimal startingBalance)
        {
            balance = startingBalance;
        }

        //Method to retrieve account balance.
        public decimal Balance
        {
            get { return balance; }
        }

        //Method to deposit money. It just adds the deposit amount to the current total.
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        //Method to withdraw money. It subtracts the withdrawal amount from the current total.
        public void Withdraw (decimal amount)
        {
            balance -= amount;
        }
    }
}
