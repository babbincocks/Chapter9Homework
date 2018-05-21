﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellphone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method to set all of the variables with the values that the user put in.
        private void GetPhoneData(Cellphone phone)
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

        //Retrieves the values put into the text boxes, and puts them into the labels.
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Cellphone currentPhone = new Cellphone();

            GetPhoneData(currentPhone);

            lblBrand.Text = currentPhone.Brand;
            lblModel.Text = currentPhone.Model;
            lblPrice.Text = currentPhone.Price.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
