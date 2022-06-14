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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Customer customer = new Customer();
            //Account account = customer.CreateAccount(accountTypeComboBox.SelectedItem.ToString(),firstNameTextBox.Text,
            //    lastNameTextBox.Text,int.Parse(ageTextBox.Text),int.Parse(amountTextBox.Text));
                //new SavingsAccount("omkar", "goskewar", 24, 500, 1001);

            AccountFactory factory = new AccountFactory();
            Account account=factory.CreateAccount(accountTypeComboBox.SelectedItem.ToString(), firstNameTextBox.Text,
                lastNameTextBox.Text, int.Parse(ageTextBox.Text), int.Parse(amountTextBox.Text));
            Form2 f2=new Form2(account);
            //Customer customer=new Customer();
            //customer.CreateAccount(comboBox1.SelectedItem.ToString());

            f2.Show();
            FindForm().Hide();
        }
    }
}
