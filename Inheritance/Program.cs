namespace IDK
{
    class Program
    {
        class A { 
            public static int YourLieInApril()
            {
                return 619;
            }
            public virtual int Calculate(int x, int y)
            {
                return x + y;
            }
        }

        class B : A
        {
            public override int Calculate(int x, int y)
            {
                return x * y;
            }
        }

        class Student
        {
            // member variables
            public string Name { get; set; }
            public int RollNo { get; set; }
            // constructor
            public Student(string name, int rollNo)
            {
                this.Name = name;
                this.RollNo = rollNo;
            }
            // introduction
            public void Introduce()
            {
                Console.WriteLine($"My name is {Name}, my roll number is {RollNo}");
            }
        }

        class VP : Student
        {
            // member variable
            private int grade;
            private int attendence;
            // constructor
            public VP(string name, int rollNo, int grade, int attendence) : base(name, rollNo)
            {
                this.grade = grade;
                this.attendence = attendence;
            }
        }



        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            Console.WriteLine(a.Calculate(10, 10));

            Console.WriteLine(b.Calculate(10, 10));

            Console.WriteLine(A.YourLieInApril());
        }
    }
}