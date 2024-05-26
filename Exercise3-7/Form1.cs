namespace Exercise3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NorthButton_Click(object sender, EventArgs e)
        {
            Location += new Size(0, -15);
        }

        private void WestButton_Click(object sender, EventArgs e)
        {
            Location += new Size(-15, 0);
        }

        private void SouthButton_Click(object sender, EventArgs e)
        {
            Location += new Size(0, 15);
        }

        private void EastButton_Click(object sender, EventArgs e)
        {
            Location += new Size(15, 0);
        }
    }
}
