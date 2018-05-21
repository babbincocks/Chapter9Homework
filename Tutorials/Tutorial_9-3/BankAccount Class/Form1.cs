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

        private BankAccount account = new BankAccount(1000);

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Text = account.Balance.ToString("c");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
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
