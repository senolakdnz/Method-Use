namespace metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void print()
        {
            textBox1.Text = "Þenol";
            textBox2.Text = "Akdeniz";
            textBox3.Text = "22";
            textBox4.Text = "Student";
        }

        void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            print();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}