using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer___Laptop
{
    internal class Laptop : Computer
    {
        private double length;
        private double width;
        private double height;
        private double weight;

        public Laptop(int wordSize, int memorySize, int storageCapacity,
            int speed, double length, double width, double height, double weight) :
            base(wordSize, memorySize, storageCapacity, speed)
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
}
