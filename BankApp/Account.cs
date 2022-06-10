using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        public Transaction transaction = new Transaction();
        public InvestmentInstrument instrument = new InvestmentInstrument();    

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Balance { get; set; } = 0;
        //public int FixedDepositBalance { get; set; } = 0;
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }

        public bool CanWithdraw { get; set; }  

        public Account() { }

        public Account(string firstName, string lastName, int age, int balance, int accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Balance = balance;
            AccountNumber = accountNumber;

            
        }

        //public bool CreateFD(int amt)
        //{
        //    if (this.Balance > amt + 1000)
        //    {
        //        this.FixedDepositBalance = this.FixedDepositBalance + amt;
        //        this.Balance = this.Balance - amt;

        //        return true;
        //    }



        //    return false;


        //}

        public bool Deposit(int amt)
        {
            this.Balance = this.Balance + amt;
            return true;
        }

        public string ViewBalance()
        {
            return this.Balance.ToString();
        }

        public bool Withdraw(int amt)
        {
            if(this.AccountType=="Savings" && amt > 10000) { return false; }

            if (CanWithdraw && amt < this.Balance)
            {
                this.Balance = this.Balance - amt;
                return true;
            }
            return false ;

            //return "Failed ! Insufficient fund/ Enter Amount less than 10000";
        }

    }
}
