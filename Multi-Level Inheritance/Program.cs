namespace IDK
{
    public class GrandParent
    {
        public void Printer()
        {
            Console.WriteLine("Grandparent Class Method!");
        }
    }

    public class Parent : GrandParent
    {
        public void Printer()
        {
            Console.WriteLine("Parent Class Method!");
        }
    }

    public class Child : Parent { }


    class Program
    {
        public static void Main()
        {
            GrandParent child1 = new Child();
            child1.Printer();

            Child child2 = new Child();
            ((GrandParent)(child2)).Printer();
        }
    }
}