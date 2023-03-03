namespace WhoCares
{
    public class Computer
    {
        private int wordSize;
        private int memorySize;
        private int storageCapacity;
        private int speed;

        public Computer(int wordSize, int memorySize, int storageCapacity, int speed)
        {
            this.wordSize = wordSize;
            this.memorySize = memorySize;
            this.storageCapacity = storageCapacity;
            this.speed = speed;
        }

        public void Details()
        {
            Console.WriteLine($" wordSize : {wordSize} Bits\n" +
                $" memorySize : {memorySize} GB");
            Console.WriteLine($" storageCapacity : {storageCapacity} GB\n" +
                $" speed : {speed} MHz");
        }
    }

    public class Laptop : Computer
    {
        private double length;
        private double width;
        private double height;
        private double weight;

        public Laptop(int wordSize, int memorySize, int storageCapacity, 
            int speed, double length, double width, double height, double weight) :
            base (wordSize, memorySize, storageCapacity, speed)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.weight = weight;
        }

        public void Details()
        {
            base.Details();
            Console.WriteLine($" length : {length}\n width : {width}");
            Console.WriteLine($" height : {height}\n weight : {weight} Kg");
        }
    }

    class program
    {
        public static void Main()
        {
            Laptop myLaptop = new Laptop(16, 8, 750, 1600, 0, 0, 0, 2.5);
            myLaptop.Details();
            Console.WriteLine("-----------------------------------");
            ((Computer)(myLaptop)).Details();
        }
    }
}