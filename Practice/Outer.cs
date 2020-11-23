using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Outer : Program
    {

        static void Main(System.String [] args)
        {
            Outer p1 = new Outer();
            p1.Test1();
            p1.Test2();
            Console.WriteLine("Updated");
            Console.ReadLine();
        }

        public override void Test1()
        {
            Console.WriteLine("Method 1");

        }

        public override void Test2()
        {
            Console.WriteLine("Method 2");

        }
    }
}
