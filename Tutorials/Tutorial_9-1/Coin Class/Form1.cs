using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnToss_Click(object sender, EventArgs e)
        {       //Code for the Coin Toss button.

            //New coin is created and all previous coin toss results are erased.
            Coin flip = new Coin();
            lbOutput.Items.Clear();

            //Coin is tosed 5 times, and the result is added each time.
            for (int count = 0; count < 5; count++)
            {
                flip.Toss();

                lbOutput.Items.Add(flip.GetSide());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
