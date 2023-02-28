using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area___Perimeter
{
    public partial class triangle_form : Form
    {
        double a, b, c;

        public triangle_form()
        {
            InitializeComponent();
        }

        private void area_btn_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(a, b, c);
            triangle.Area();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (a >= 0)
            {
                a = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                Console.WriteLine("Value of A cannot be negative.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (b >= 0)
            {
                b = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                Console.WriteLine("Value of B cannot be negative.");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (c >= 0)
            {
                c = Convert.ToDouble(textBox3.Text);
            }
            else
            {
                Console.WriteLine("Value of C cannot be negative.");
            }
        }

        private void perimeter_btn_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle(a, b, c);
            triangle.Perimeter();
        }
    }
}
