namespace FinancialCalculations
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnExit = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btnDepreciation = new System.Windows.Forms.Button();
            btnInvestment = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(294, 249);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(72, 27);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDepreciation);
            panel1.Controls.Add(btnInvestment);
            panel1.Location = new System.Drawing.Point(14, 142);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(366, 89);
            panel1.TabIndex = 10;
            // 
            // btnDepreciation
            // 
            btnDepreciation.Location = new System.Drawing.Point(15, 48);
            btnDepreciation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDepreciation.Name = "btnDepreciation";
            btnDepreciation.Size = new System.Drawing.Size(335, 27);
            btnDepreciation.TabIndex = 1;
            btnDepreciation.Text = "Calculate SYD Depreciation";
            btnDepreciation.Click += btnDepreciation_Click;
            // 
            // btnInvestment
            // 
            btnInvestment.Location = new System.Drawing.Point(15, 15);
            btnInvestment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInvestment.Name = "btnInvestment";
            btnInvestment.Size = new System.Drawing.Size(335, 27);
            btnInvestment.TabIndex = 0;
            btnInvestment.Text = "Calculate Investment";
            btnInvestment.Click += btnInvestment_Click;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(147, 102);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(233, 23);
            label3.TabIndex = 9;
            label3.Text = "Copyright (c) 2020, All rights reserved";
            label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(147, 38);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(225, 63);
            label2.TabIndex = 8;
            label2.Text = "Financial Calculations";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(147, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(233, 23);
            label1.TabIndex = 7;
            label1.Text = "Mike Murach && Associates, Inc.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(14, 14);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(124, 110);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 251);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(157, 23);
            button1.TabIndex = 12;
            button1.Text = "Does Nothing Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(390, 290);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Financial Calculations";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDepreciation;
        private System.Windows.Forms.Button btnInvestment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

