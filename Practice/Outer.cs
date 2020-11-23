using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Outer : Interface1,Interface2
    {

        static void Main(System.String[] args)
        {
            Outer obj = new Outer();
            Interface1 i1 = obj;
            i1.show1();
            Interface2 i2 = obj;
            i2.show1();
            obj.show2();
            obj.show3();
            Console.ReadLine();
        }

        void Interface1.show1()
        {
            Console.WriteLine("show 1 of interface 1");
        }
        void Interface2.show1()
        {
            Console.WriteLine("show 1 of interface 2");
        }

        public void show2()
        {
            Console.WriteLine("show 2");
        }

        public void show3()
        {
            Console.WriteLine("show 3");
        }
    }
}
