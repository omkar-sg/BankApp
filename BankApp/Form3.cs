using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form3 : Form
    {
        InvestmentFactory factory = new InvestmentFactory();
        Account account;
        InvestmentInstrument fd ;
        InvestmentInstrument rd;
        public Form3()
        {
            InitializeComponent();
            
        }

        public Form3(Account account)
        {
            this.account = account;
            this.fd = factory.CreateInvestmentAcc("Fixed");
            this.rd = factory.CreateInvestmentAcc("Recurring");
            InitializeComponent();
        }

        private void createFDButton_Click(object sender, EventArgs e)
        {
            var amt = Convert.ToInt32(createFDTextBox.Text);
            var msg=account.transaction.onWithdraw(amt);
            //var fd = factory.CreateInvestmentAcc("Fixed");
            if (msg) { fd.transaction.onFixDeposit(amt); MessageBox.Show("Fixed Diposit Created"); }
            else { MessageBox.Show(" Fixed Diposit Creation Failed"); }
            
            
            //fd.CreateInvestment();

        }

        private void viewFDButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fd.Balance.ToString());
        }

        private void createRDButton_Click(object sender, EventArgs e)
        {
            var amt = Convert.ToInt32(createRDTextBox.Text);
            var msg = account.transaction.onWithdraw(amt);
            //var fd = factory.CreateInvestmentAcc("Fixed");
            if (msg) { rd.transaction.onRecurringDeposit(amt); MessageBox.Show("Recurring Diposit Created"); }
            else { MessageBox.Show(" Recurring Diposit Creation Failed"); }

        }

        private void viewRDButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rd.Balance.ToString());
        }
    }
}
