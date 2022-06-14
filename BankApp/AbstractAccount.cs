using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public abstract class AbstractAccount
    {
        public int AccountNumber { get; set; }
        public abstract string AccountDetails();
    }
}
