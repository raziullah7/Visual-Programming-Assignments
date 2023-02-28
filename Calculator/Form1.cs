using System.Data;

namespace Calculator__Assignment1_
{
    public partial class Form1 : Form
    {
        // the string that gets entered in the textbox
        string expression;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            expression = textBox1.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            expression += "0";
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression += "1";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            expression += "3";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expression += "4";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression += "5";
            textBox1.Text += "5";        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression += "6";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression += "7";
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression += "8";
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression += "9";
            textBox1.Text += "9";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            expression += "+";
            textBox1.Text += "+";
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            expression += "-";
            textBox1.Text += "-";
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            expression += "*";
            textBox1.Text += "*";
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            expression += "/";
            textBox1.Text += "/";
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            // starting input validation
            if (expression[0].Equals("+") || expression[0].Equals("-") ||
                expression[0].Equals("*") || expression[0].Equals("/"))
            {
                MessageBox.Show("Invalid Input!");
            }

            // in case of a proper expression
            else if (expression.Contains('+') || expression.Contains('-')
                || expression.Contains('*') || expression.Contains('/'))
            {
                double result = Convert.ToDouble(new DataTable().Compute(expression, null));
                MessageBox.Show("Result = " + result);
            }

            // if there are no operators, then simply print the expression
            else
            {
                MessageBox.Show("Result = " + expression);
            }
        }
    }
}