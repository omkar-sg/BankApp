using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class InvestmentFactory 
    {
        public InvestmentInstrument CreateInvestmentAcc(string InvestmentType)
        {
            if (InvestmentType == "Fixed")
            {
                return new FixedDiposit();
            }

            return new RecurringDeposit();
        }
    }
}
