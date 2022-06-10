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
    public partial class Form2 : Form
    {
        Account account;
        InvestmentInstrument fixedDiposit = new InvestmentInstrument();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2 (Account account)
        {  
            this.account = account;
            
            //transaction.withdraw += account.Withdraw;
            //transaction.deposit+=account.Deposit;
            //transaction.fixdeposit += account.CreateFD;
            InitializeComponent();
            nameLabel.Text = account.FirstName.ToUpper();
            lastNameLabel.Text = account.LastName.ToUpper();
            accountTypeLabel.Text = account.AccountType;
            ageLabel.Text = account.Age.ToString();

        }

        private void viewBalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show( account.Balance.ToString());
        }

        private void widrawButton_Click(object sender, EventArgs e)
        {
            var amount = Convert.ToInt32(widrawTextBox.Text);
           bool withDrawMessage= this.account.transaction.onWithdraw(amount);
            if (withDrawMessage) { MessageBox.Show("Amount Widrawn :" + amount); }
            else { MessageBox.Show("Not sufficient funds/ Enter Amount less than 10000"); }
            
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            var amount= int.Parse(depositeTextBox.Text);
            bool depositeMessage=this.account.transaction.onDeposit(amount);
            if (depositeMessage) { MessageBox.Show("Deposited Successfully : " + amount); }
            else { MessageBox.Show("Deposited Failed "); }
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.account.transaction.fixdeposit += fixedDiposit.CreateFD;
        }

        private void createFixedDipositeButton_Click(object sender, EventArgs e)
        {
            var amount = int.Parse(createFixedDipositeTextBox.Text);
            //this.account.transaction.onFixDeposit(amount,20);

            
            bool fdMessage= this.account.transaction.onWithdraw(amount);
            if (fdMessage) {
                this.account.transaction.onFixDeposit(amount);
                MessageBox.Show("Deposited Successfully : " + amount);
                
            }
            
        }

        private void viewFixedDipositeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fixedDiposit.FixedDiposit.ToString());
        }
    }
}
