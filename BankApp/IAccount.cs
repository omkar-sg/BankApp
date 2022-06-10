using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    // Created initially and as suggested by sir
    public interface IAccount
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        int Balance { get; set; }
        int FD { get; set; } 
        int AccountNumber { get; set; }
        string AccountType { get; }    
        string ViewBalance();
        void Widraw(int amt);
        void Deposite(int amt);

        bool CreateFD(int amt);
    }
}
