namespace Different_Form_Control_Access
{
    partial class NutritionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFood = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFood
            // 
            this.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFood.Location = new System.Drawing.Point(124, 43);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(133, 25);
            this.lblFood.TabIndex = 0;
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalories
            // 
            this.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalories.Location = new System.Drawing.Point(124, 83);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(133, 25);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFat
            // 
            this.lblFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFat.Location = new System.Drawing.Point(124, 128);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(133, 25);
            this.lblFat.TabIndex = 2;
            this.lblFat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCarb
            // 
            this.lblCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarb.Location = new System.Drawing.Point(124, 167);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(133, 25);
            this.lblCarb.TabIndex = 3;
            this.lblCarb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fat Grams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carb Grams";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCarb);
            this.Controls.Add(this.lblFat);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblFood);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFood;
        public System.Windows.Forms.Label lblCalories;
        public System.Windows.Forms.Label lblFat;
        public System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
    }
}