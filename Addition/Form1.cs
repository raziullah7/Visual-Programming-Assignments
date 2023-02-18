namespace Addition
{
    public partial class Form1 : Form
    {
        int num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{num1} + {num2} = {num1 + num2}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox2.Text);
        }
    }
}