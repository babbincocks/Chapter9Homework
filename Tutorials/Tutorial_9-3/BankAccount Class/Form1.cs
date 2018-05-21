using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creates an instance of the BankAccount class with a starting balance of $1000.
        private BankAccount account = new BankAccount(1000);

        private void Form1_Load(object sender, EventArgs e)
        {
            //Puts the account balance into the Balance label up top.
            lblBalance.Text = account.Balance.ToString("c");
        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //If the inputted value is a numeric value, it deposits it into the account balance and updates displayed fields.
            if (decimal.TryParse(txtDeposit.Text, out decimal amount))
            {
                account.Deposit(amount);

                lblBalance.Text = account.Balance.ToString("c");

                txtDeposit.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Same as the deposit button, but it withdraws instead.
            if (decimal.TryParse(txtWithdraw.Text, out decimal amount))
            {
                account.Withdraw(amount);

                lblBalance.Text = account.Balance.ToString("c");

                txtWithdraw.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
