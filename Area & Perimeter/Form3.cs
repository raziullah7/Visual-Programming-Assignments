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
    public partial class rectangle_form : Form
    {
        double length, width;
        public rectangle_form()
        {
            InitializeComponent();
        }

        private void area_btn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(length, width);
            rectangle.Area();
        }

        private void perimeter_btn_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(length, width);
            rectangle.Perimeter();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (length >= 0)
            {
                length = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                Console.WriteLine("Value of Length cannot be negative.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (width >= 0)
            {
                width = Convert.ToDouble(textBox2.Text);
            }
            else
            {
                Console.WriteLine("Value of A cannot be negative.");
            }
        }

    }
}
