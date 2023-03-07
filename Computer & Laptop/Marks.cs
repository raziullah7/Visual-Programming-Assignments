using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer___Laptop
{
    internal class Marks
    {
        private double marks1;
        private double marks2;
        private double marks3;

        public void In(double marks1, double marks2, double marks3)
        {
            this.marks1 = Math.Round(marks1, 2);
            this.marks2 = Math.Round(marks2, 2);
            this.marks3 = Math.Round(marks3, 2);
        }

        public double Sum()
        {
            return marks1 + marks2 + marks3;
        }

        public double Avg()
        {
            return (Sum() / 3);
        }
    }
}
