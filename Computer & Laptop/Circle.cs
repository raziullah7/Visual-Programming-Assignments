using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer___Laptop
{
    internal class Circle
    {
        private double radius;

        public void getRadius(double value)
        {
            this.radius = value;
        }

        public void Area()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle : {Math.Round(area, 2)}");
        }

        public void Circum()
        {
            double circum = 2 * Math.PI * radius;
            Console.WriteLine($"Circumference of Circle : {Math.Round(circum, 2)}");
        }
    }

    
}
