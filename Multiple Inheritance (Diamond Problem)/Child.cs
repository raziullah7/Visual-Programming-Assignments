using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance__Diamond_Problem_
{
    public class Child : Mother, Father
    {
        public void Msg1()
        {
            Console.WriteLine("Mother Message Called!");
        }

        public void Msg2()
        {
            Console.WriteLine("Father Message Called!");
        }
    }
}
