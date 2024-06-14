namespace payroll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picMoney = new PictureBox();
            lblHours = new Label();
            lblHourlyRate = new Label();
            txtboxHours = new TextBox();
            txtboxHourlyRate = new TextBox();
            txtboxPayAmount = new TextBox();
            lblPayAmount = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            txtCalculationDetails = new GroupBox();
            lblRegularPay = new Label();
            lblOTPay = new Label();
            txtboxOTPay = new TextBox();
            txtboxRegularPay = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picMoney).BeginInit();
            txtCalculationDetails.SuspendLayout();
            SuspendLayout();
            // 
            // picMoney
            // 
            picMoney.BackgroundImage = (Image)resources.GetObject("picMoney.BackgroundImage");
            picMoney.BackgroundImageLayout = ImageLayout.Stretch;
            picMoney.Location = new Point(12, 12);
            picMoney.Name = "picMoney";
            picMoney.Size = new Size(100, 86);
            picMoney.SizeMode = PictureBoxSizeMode.CenterImage;
            picMoney.TabIndex = 0;
            picMoney.TabStop = false;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(12, 132);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(83, 15);
            lblHours.TabIndex = 1;
            lblHours.Text = "Hours Worked";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(12, 173);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(69, 15);
            lblHourlyRate.TabIndex = 2;
            lblHourlyRate.Text = "Hourly Rate";
            // 
            // txtboxHours
            // 
            txtboxHours.Location = new Point(101, 129);
            txtboxHours.Name = "txtboxHours";
            txtboxHours.Size = new Size(100, 23);
            txtboxHours.TabIndex = 3;
            // 
            // txtboxHourlyRate
            // 
            txtboxHourlyRate.Location = new Point(101, 170);
            txtboxHourlyRate.Name = "txtboxHourlyRate";
            txtboxHourlyRate.Size = new Size(100, 23);
            txtboxHourlyRate.TabIndex = 4;
            // 
            // txtboxPayAmount
            // 
            txtboxPayAmount.Enabled = false;
            txtboxPayAmount.Location = new Point(101, 261);
            txtboxPayAmount.Name = "txtboxPayAmount";
            txtboxPayAmount.Size = new Size(100, 23);
            txtboxPayAmount.TabIndex = 5;
            // 
            // lblPayAmount
            // 
            lblPayAmount.AutoSize = true;
            lblPayAmount.Location = new Point(12, 264);
            lblPayAmount.Name = "lblPayAmount";
            lblPayAmount.Size = new Size(73, 15);
            lblPayAmount.TabIndex = 6;
            lblPayAmount.Text = "Pay Amount";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 217);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCalculationDetails
            // 
            txtCalculationDetails.Controls.Add(lblRegularPay);
            txtCalculationDetails.Controls.Add(lblOTPay);
            txtCalculationDetails.Controls.Add(txtboxOTPay);
            txtCalculationDetails.Controls.Add(txtboxRegularPay);
            txtCalculationDetails.Location = new Point(12, 290);
            txtCalculationDetails.Name = "txtCalculationDetails";
            txtCalculationDetails.Size = new Size(200, 100);
            txtCalculationDetails.TabIndex = 9;
            txtCalculationDetails.TabStop = false;
            txtCalculationDetails.Text = "Calculation Details";
            // 
            // lblRegularPay
            // 
            lblRegularPay.AutoSize = true;
            lblRegularPay.Location = new Point(14, 30);
            lblRegularPay.Name = "lblRegularPay";
            lblRegularPay.Size = new Size(69, 15);
            lblRegularPay.TabIndex = 3;
            lblRegularPay.Text = "Regular Pay";
            // 
            // lblOTPay
            // 
            lblOTPay.AutoSize = true;
            lblOTPay.Location = new Point(14, 62);
            lblOTPay.Name = "lblOTPay";
            lblOTPay.Size = new Size(78, 15);
            lblOTPay.TabIndex = 2;
            lblOTPay.Text = "Overtime Pay";
            // 
            // txtboxOTPay
            // 
            txtboxOTPay.Location = new Point(94, 59);
            txtboxOTPay.Name = "txtboxOTPay";
            txtboxOTPay.Size = new Size(100, 23);
            txtboxOTPay.TabIndex = 1;
            // 
            // txtboxRegularPay
            // 
            txtboxRegularPay.Location = new Point(89, 27);
            txtboxRegularPay.Name = "txtboxRegularPay";
            txtboxRegularPay.Size = new Size(100, 23);
            txtboxRegularPay.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(291, 430);
            Controls.Add(txtCalculationDetails);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblPayAmount);
            Controls.Add(txtboxPayAmount);
            Controls.Add(txtboxHourlyRate);
            Controls.Add(txtboxHours);
            Controls.Add(lblHourlyRate);
            Controls.Add(lblHours);
            Controls.Add(picMoney);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Payroll Calculation";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picMoney).EndInit();
            txtCalculationDetails.ResumeLayout(false);
            txtCalculationDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picMoney;
        private Label lblHours;
        private Label lblHourlyRate;
        private TextBox txtboxHours;
        private TextBox txtboxHourlyRate;
        private TextBox txtboxPayAmount;
        private Label lblPayAmount;
        private Button btnCalculate;
        private Button btnClear;
        private GroupBox txtCalculationDetails;
        private Label lblRegularPay;
        private Label lblOTPay;
        private TextBox txtboxOTPay;
        private TextBox txtboxRegularPay;
    }
}
