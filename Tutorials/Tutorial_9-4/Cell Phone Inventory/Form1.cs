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

        //List to hold all of the different phones that can be created.
        List<CellPhone> phoneList = new List<CellPhone>();

        //Method to gather all phone data from the text boxes.
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

        //Creates a new phone, executes the previous method, and adds the new phone number into the phone list, and displays it
        //in the list box; then most controls reset.
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
        {       //Code for changing highlighted item in the list box.

            //Since items in the list and the list box are in the same order, it gets the index that was clicked. Then the item in the list
            //with the same index has its price retrieved, and displayed in a message box.
            int index = lbPhones.SelectedIndex;

            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
