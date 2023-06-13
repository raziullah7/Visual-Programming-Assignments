using System;

namespace Number_Range__Graded_Assignment_14Feb_
{
    public partial class Form1 : Form
    {
        string num;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // correct input case
            if (Convert.ToInt32(num) >= 10 && Convert.ToInt32(num) <= 20)
            {
                MessageBox.Show($"Correct Input, You Entered {num}");
            }
            // wrong input case
            else
            {
                MessageBox.Show("Incorrect Input, Enter a Number Between 10 and 20.\n" +
                        "(It's not that hard XD)");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}