﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_Form_Application
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }
        //Since this form is modal, it will close only this form if closed.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
