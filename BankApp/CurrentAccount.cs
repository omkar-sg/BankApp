using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    

    public class CurrentAccount:Account
    {
        public CurrentAccount(string firstName, string lastName, int age, int balance, int accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Balance = balance;
            AccountNumber = accountNumber;
            CanWithdraw = true;
            AccountType = "Current";

            transaction.withdraw += this.Withdraw;
            transaction.deposit += this.Deposit;

        }
        
    }
}
