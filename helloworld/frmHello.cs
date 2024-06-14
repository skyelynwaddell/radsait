/*Skye Waddell RAD 2024 | v1.0*/
namespace helloworld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnGreetMe_Click(object sender, EventArgs e)
        {
            lblDisplayName.Text = $"Welcome to The Matrix {txtboxWelcome.Text}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDisplayName.Text = "";
            //txtboxWelcome.Text = "";
            txtboxWelcome.Clear();
            txtboxWelcome.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
