using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    //public delegate void transactionEventHandler(int amt);
    //public delegate bool fdEventHandler(int amt);
    public class Customer
    {

        static int AccountNumber = 1001;
        //List<IAccount> accounts=new List<IAccount>();

        public Account CreateAccount(string accountType,string firstname,string lastname,int age,int amount)
        {
            /* accounts.Add(new SavingsAccount("omkar","goskewar",24,500,1001));
             Console.WriteLine(accounts.Count() +" "+accountType);

             foreach(var account in accounts) { Console.WriteLine(account.FirstName+" "+account.LastName) ; }*/


            if (accountType == "Savings")
            {
                return new SavingsAccount(firstname, lastname, age, amount, AccountNumber++);

            }

            return new CurrentAccount(firstname, lastname, age, amount, AccountNumber++);
        }


    }




    /*public class Transaction
    {
        public event transactionEventHandler widraw, deposite ;
        public event fdEventHandler fixdeposite;

        public void onWidraw(int amt)
        {
            if (widraw != null)
            {
                widraw(amt);
            }
        }

        public void onDeposite(int amt)
        {
            if (deposite != null)
            {
                deposite(amt);
            }
        }

        public void onFixDeposite(int amt)
        {
            if (fixdeposite!= null)
            {
                fixdeposite(amt);

            }
        }

    }*/
}
