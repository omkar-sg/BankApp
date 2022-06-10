using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public delegate bool transactionEventHandler(int amt);
    public delegate bool fdEventHandler(int amt);
    public class Transaction
    {
        public event transactionEventHandler withdraw, deposit;
        public event fdEventHandler fixdeposit;

        public bool onWithdraw(int amt)
        {
            if (withdraw != null)
            {
               return withdraw(amt);
            }
            return false;
        }

        public bool onDeposit(int amt)
        {
            if (deposit != null)
            {
               return deposit(amt);
            }
            return false;
        }

        public bool onFixDeposit(int amt)
        {
            if (fixdeposit != null)
            {
               return fixdeposit(amt);

            }
            return false;
        }

    }
}
