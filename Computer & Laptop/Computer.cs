using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer___Laptop
{
    internal class Computer
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
}
