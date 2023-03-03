using System.Reflection.Metadata;

namespace AbstractShape
{
    // abstract Shape class
    public abstract class Shape2
    {
        protected double area;
        protected double perimeter;
        public abstract void Area();
        public abstract void Perimeter();
    }


    // Triangle class
    public class Triangle : Shape2
    {
        private double side1;
        private double side2;
        private double side3;
        // semi-parameter
        private double s;

        // constructor
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            // computation of semi-perimeter
            s = (side1 + side2 + side3) / 2;
        }

        // area method implementation
        public override void Area()
        {
            area = Math.Round(Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)), 2);
            Console.WriteLine($"Area of Triangle : {area} unit sq.");
        }
        // perimeter method implementation
        public override void Perimeter()
        {
            perimeter = side1 + side2 + side3;
            Console.WriteLine($"Perimeter of Triangle : {perimeter} units");
        }
    }


    // Rectangle class
    public class Rectangle : Shape2
    {
        // private double radius;
        private double length;
        private double width;

        // constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // area method implementation
        public override void Area()
        {
            area = Math.Round(length * width, 2);
            Console.WriteLine($"Area of Rectangle : {area} unit sq.");
        }
        // perimeter method implementation
        public override void Perimeter()
        {
            perimeter = 2 * (length + width);
            Console.WriteLine($"Perimeter of Rectangle : {perimeter} units");
        }
    }


    // main
    class Program
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(5, 5, 5);
            triangle.Area();
            triangle.Perimeter();

            Console.WriteLine("-----------------------------------");

            Rectangle rectangle = new Rectangle(10, 10);
            rectangle.Area();
            rectangle.Perimeter();
        }
    }
}