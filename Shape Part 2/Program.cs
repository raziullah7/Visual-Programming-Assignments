using System.Reflection.Metadata;

namespace AbstractShape
{
    // abstract Shape class
    public abstract class Shape2
    {
        protected double area;
        protected double perimeter;
        public abstract void Area();
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
            // computation
            perimeter = side1 + side2 + side3;
            s = perimeter / 2;
        }

        // area method implementation
        public override void Area()
        {
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            Console.WriteLine($"Area of Triangle : {area}");
        }
    }
    // Rectangle class
    public class Rectangle : Shape2
    {
        // private double radius;
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            // computation
            perimeter = 2 * (length + width);
        }

        // area method implementation
        public override void Area()
        {
            area = length * width;
            Console.WriteLine($"Area of Rectangle : {area}");
        }
    }
    // main
    class Program
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(5, 5, 5);

        }
    }
}