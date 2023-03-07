namespace Computer___Laptop
{
    class program
    {
        public static void Main()
        {
            Laptop myLaptop = new Laptop(16, 8, 750, 1600, 0, 0, 0, 2.5);
            myLaptop.Details();
            Console.WriteLine("-----------------------------------");
            ((Computer)(myLaptop)).Details();

            Console.WriteLine();

            Circle circle = new Circle();
            circle.getRadius(5);
            circle.Area();

            Console.WriteLine();

            Marks marks = new Marks();
            marks.In(55, 65, 75);
            Console.WriteLine("Average Score : " + marks.Avg());
        }
    }
}