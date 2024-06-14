/*
 * Calculate pay amount
 * Full week is 37.5 hrs
 * overtime factor: 1.5
 * author: skye waddell
 * june 2024
 */

namespace payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCalculationDetails.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //make sure the textbox contains correct type of data
            if (txtboxHours.Text == "" || txtboxHourlyRate.Text == "")
            {
                return;
            }

            const decimal FULL_WEEK = 37.5m;
            const decimal OT_RATE = 1.5m;

            decimal hours; //total hrs worked
            decimal rate;  //hourly rate
            decimal pay;   //employee pay
            decimal regularPay;
            decimal overtimePay;

            //get hours and rate
            hours = Convert.ToDecimal(txtboxHours.Text);
            rate = Convert.ToDecimal(txtboxHourlyRate.Text);

            if (hours <= FULL_WEEK)
            {
                // Regular pay
                regularPay = hours * rate;
                overtimePay = 0;
                txtCalculationDetails.Visible = false;

            }
            else
            {
                //overtime pay
                regularPay = FULL_WEEK * rate;
                overtimePay = (hours - FULL_WEEK) * rate * OT_RATE;
                txtCalculationDetails.Visible = true;
            }
            pay = regularPay + overtimePay;

            // Display pay in currency format
            txtboxPayAmount.Text = pay.ToString("c");
            txtboxRegularPay.Text = regularPay.ToString("c");
            txtboxOTPay.Text = overtimePay.ToString("c");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxHourlyRate.Clear();
            txtboxHours.Clear();
            txtboxPayAmount.Clear();
            txtboxRegularPay.Clear();
            txtboxOTPay.Clear();
            txtCalculationDetails.Visible = false;

            txtboxHours.Focus();
        }

    }
}
