using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class FixedDiposit:InvestmentInstrument
    {
        public FixedDiposit()
        {
            InvestmentType = "Fixed";
            transaction.fixdeposit += this.CreateInvestment;
        }

        
    }
}
