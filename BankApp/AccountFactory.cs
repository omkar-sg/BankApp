using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class AccountFactory : AbstractAccountFactory
    {
        public override Account CreateAccount(string AccountType, string firstName, string lastName, int age, int balance)
        {
            if (AccountType == "Savings")
            {
                return new SavingsAccount(firstName, lastName, age, balance, AccountNumber++);
            }

            return new CurrentAccount(firstName, lastName, age, balance, AccountNumber++);
        }
    }
}
