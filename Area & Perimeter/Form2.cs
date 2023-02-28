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
    // Triangle class
    public class Triangle : Shape
    {
        // using three sides to solve area
        // and perimeter
        private double sideA;
        private double sideB;
        private double sideC;
        // s = perimeter / 2
        // semi-perimeter
        private double s;
        // constructor
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            // computation
            perimeter = sideA + sideB + sideC;
            s = perimeter / 2;
            area = Math.Sqrt(s * (s-sideA) * (s - sideB) * (s - sideC));
        }
        // area implemetation
        public override void Area()
        {
            MessageBox.Show($"Area of Triangle = {area}");
        }
        // perimeter implementation
        public override void Perimeter()
        {
            MessageBox.Show($"Perimeter of Triangle = {perimeter}");
        }
    }
    public partial class triangle_form : Form
    {
        
        public triangle_form()
        {
            InitializeComponent();
        }

        private void area_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
