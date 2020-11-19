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
            p1.test2();
            p1.test3();
            p1.test4();
            p1.test5();
            Console.WriteLine("Updated");
        }
    }
}
