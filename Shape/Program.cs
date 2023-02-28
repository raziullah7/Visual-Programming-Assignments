namespace Shape
{
    // shape class
    public class Shape
    {
        protected double radius;
        protected double length;
        protected double width;
        protected double side1;
        protected double side2;
        protected double side3;
        // double area;
        // double parameter
        
        // constructor overloading
        public Shape(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public Shape(double radius)
        {
            this.radius = radius;
        }
        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual void Area()
        {
            Console.Write($"The Area is ");
        }
    }

    // circle class
    public class Circle : Shape
    {
        double area;
        public Circle(double radius)
            : base (radius) { }

        public override void Area()
        {
            area = Math.Round(Math.PI * radius * radius, 2);
            base.Area();
            Console.WriteLine(area + " unit sq.");
        }
    }

    // rectangle class
    public class Rectangle : Shape
    {
        double area;
        public Rectangle(double length, double width)
            : base (length, width) { }

        public override void Area()
        {
            area = Math.Round(length * width, 2);
            base.Area();
            Console.WriteLine(area + " unit sq.");
        }
    }

    // triangle class
    public class Triangle : Shape
    {
        // double area;
        // double parameter
        public Triangle(double side1, double side2, double side3) :
            base(side1, side2, side3) { }

        public void typeOfTriangle()
        {
            if (side1 == side2 && side1 != side3)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Triangle is Equivilateral");
            }
            else if (side1 != side2 && side1 != side3)
            {
                Console.WriteLine("Scalane");
            }
            else
            {
                Console.WriteLine("Pata nahi, khud bhi kuch parh lia kro.");
            }

        }
    }

    // class for writing main method
    class Program
    {
        static void Main()
        {
            Shape s1 = new Circle(7);
            s1.Area();

            Shape s2 = new Rectangle(5, 5);
            s2.Area();

            Triangle triangle = new Triangle(2, 2, 2);
            triangle.typeOfTriangle();
        }
    }
}
