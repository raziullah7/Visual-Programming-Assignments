namespace IDK
{
    public delegate void Calculation();
    public delegate int Calc(int a, int b);

    class Program
    {
        static void add()
        {
            int a, b, c;
            Console.Write("Enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number : ");
            c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine("Sum of Three Numbers : " + sum);
        }
        
        static void product()
        {
            int a = 10, b = 20;
            Console.WriteLine($"Product of {a} and {b} = {a * b}");
        }

        static int multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            // using add() method as parameter for the delegate
            Calculation obj1 = new Calculation(add);
            // invoking the delegate with add()
            // obj1.Invoke();
            obj1 += product;
            // invokes for product
            obj1.Invoke();

            //Calculation obj2 = new Calculation(multiply);
            //// invoking the delegate with multiply()
            //obj2.Invoke();

            Calc obj3 = new Calc(multiply);
            Console.WriteLine($"Multiply Result : {obj3.Invoke(2, 15)}");
            
        }
    }
}