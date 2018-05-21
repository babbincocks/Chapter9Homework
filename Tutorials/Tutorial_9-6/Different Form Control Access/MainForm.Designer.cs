namespace Different_Form_Control_Access
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBanana = new System.Windows.Forms.RadioButton();
            this.rbPopcorn = new System.Windows.Forms.RadioButton();
            this.rbMuffin = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMuffin);
            this.groupBox1.Controls.Add(this.rbPopcorn);
            this.groupBox1.Controls.Add(this.rbBanana);
            this.groupBox1.Location = new System.Drawing.Point(61, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a food";
            // 
            // rbBanana
            // 
            this.rbBanana.AutoSize = true;
            this.rbBanana.Location = new System.Drawing.Point(27, 35);
            this.rbBanana.Name = "rbBanana";
            this.rbBanana.Size = new System.Drawing.Size(70, 17);
            this.rbBanana.TabIndex = 0;
            this.rbBanana.TabStop = true;
            this.rbBanana.Text = "1 banana";
            this.rbBanana.UseVisualStyleBackColor = true;
            // 
            // rbPopcorn
            // 
            this.rbPopcorn.AutoSize = true;
            this.rbPopcorn.Location = new System.Drawing.Point(27, 58);
            this.rbPopcorn.Name = "rbPopcorn";
            this.rbPopcorn.Size = new System.Drawing.Size(145, 17);
            this.rbPopcorn.TabIndex = 1;
            this.rbPopcorn.TabStop = true;
            this.rbPopcorn.Text = "1 cup of popped popcorn";
            this.rbPopcorn.UseVisualStyleBackColor = true;
            // 
            // rbMuffin
            // 
            this.rbMuffin.AutoSize = true;
            this.rbMuffin.Location = new System.Drawing.Point(27, 81);
            this.rbMuffin.Name = "rbMuffin";
            this.rbMuffin.Size = new System.Drawing.Size(134, 17);
            this.rbMuffin.TabIndex = 2;
            this.rbMuffin.TabStop = true;
            this.rbMuffin.Text = "1 large blueberry muffin";
            this.rbMuffin.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(79, 198);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(79, 37);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Food Facts";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(193, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Food Facts";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMuffin;
        private System.Windows.Forms.RadioButton rbPopcorn;
        private System.Windows.Forms.RadioButton rbBanana;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
    }
}

