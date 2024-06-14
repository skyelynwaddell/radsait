namespace chickenegg
{
    public partial class frmMain : Form
    {

        String path = "..\\..\\..\\images\\";

        public frmMain()
        {
            InitializeComponent();
        }

        private void radioEgg_CheckedChanged(object sender, EventArgs e)
        {
            //user selected egg radio button
            picAnswer.Image = Image.FromFile(path + "Egg.png");
        }

        private void radioChicken_CheckedChanged(object sender, EventArgs e)
        {
            //user selected chicken radio button
            picAnswer.Image = Image.FromFile(path + "Large_Cucco.png");
        }
    }
}
