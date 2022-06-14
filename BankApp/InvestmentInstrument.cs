using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class InvestmentInstrument:AbstractAccount
    {
        public Transaction transaction = new Transaction();
        //public int FixedDiposit { get; set; }=0;
        public int Balance { get; set; }
        public string InvestmentType { get; set; }
        //public int RecurringDiposit { get; set; }

        public override string AccountDetails()
        {
            return string.Format("Investment Type : {0}  Available Balance : {1} ",InvestmentType, Balance);
        }


        //public bool CreateFD(int amt)
        //{
        //    FixedDiposit=FixedDiposit+amt;
        //    return true;

        //}

        public bool CreateInvestment(int amt)
        {
            Balance = Balance + amt;
            return true;

        }

        //public bool CreateRD(int amt)
        //{
        //    RecurringDiposit = RecurringDiposit+amt;
        //    return true;
        //}
        


    }
}
