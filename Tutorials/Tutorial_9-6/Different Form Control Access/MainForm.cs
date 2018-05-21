using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Different_Form_Control_Access
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void btnDisplay_Click(object sender, EventArgs e)
        {       //Code for the Display button.

            //Creates a new instance of the other Windows form.
            NutritionForm newForm = new NutritionForm();

            //Then checks which radio button is clicked and populates the fields of this new form with the information of the item that was
            //clicked.
            if (rbBanana.Checked)
            {
                newForm.lblFood.Text = "1 banana";
                newForm.lblCalories.Text = "100";
                newForm.lblFat.Text = "0.4";
                newForm.lblCarb.Text = "27";
            }
            else if (rbPopcorn.Checked)
            {
                newForm.lblFood.Text = "1 cup of popped popcorn";
                newForm.lblCalories.Text = "31";
                newForm.lblFat.Text = "0.4";
                newForm.lblCarb.Text = "6";
            }
            else if (rbMuffin.Checked)
            {
                newForm.lblFood.Text = "1 large blueberry muffin";
                newForm.lblCalories.Text = "385";
                newForm.lblFat.Text = "9";
                newForm.lblCarb.Text = "67";
            }

            //Then it displays the form.
            newForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
