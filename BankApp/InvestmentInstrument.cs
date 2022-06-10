using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class InvestmentInstrument
    {
        public int FixedDiposit { get; set; }=0;
        public int RecurringDiposit { get; set; }

        public bool CreateFD(int amt)
        {
            FixedDiposit=FixedDiposit+amt;
            return true;

        }
        


    }
}
