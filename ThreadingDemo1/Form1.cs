namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}
