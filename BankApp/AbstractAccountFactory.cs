using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public abstract class AbstractAccountFactory
    {
        public int AccountNumber { get; set; }

        public abstract Account CreateAccount(string AccountType, string firstName, string lastName, int age, int balance);
    }
}
