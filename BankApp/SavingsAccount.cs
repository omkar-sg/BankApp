using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class SavingsAccount : Account, IEnumerable 
    {
        
        public SavingsAccount(string firstName, string lastName, int age, int balance, int accountNumber)

        {

            
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Balance = balance;
            AccountNumber = accountNumber;
            CanWithdraw = true;
            AccountType = "Savings";

            transaction.withdraw += this.Withdraw;
            transaction.deposit += this.Deposit;

        }

        public AccountEnum GetEnumerator()
        {
            return new AccountEnum(FirstName, LastName);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
