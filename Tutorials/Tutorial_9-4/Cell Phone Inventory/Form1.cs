using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CellPhone> phoneList = new List<CellPhone>();

        private void GetPhoneData(CellPhone phone)
        {
            decimal price;

            phone.Brand = txtBrand.Text;

            phone.Model = txtModel.Text;

            if (decimal.TryParse(txtPrice.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();

            GetPhoneData(phone);

            phoneList.Add(phone);

            lbPhones.Items.Add(phone.Brand + " " + phone.Model);

            txtBrand.Clear();
            txtModel.Clear();
            txtPrice.Clear();

            txtBrand.Focus();
        }

        private void lbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPhones.SelectedIndex;

            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
