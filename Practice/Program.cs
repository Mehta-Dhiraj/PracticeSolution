using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        private void test1() => Console.WriteLine("Private member");
        internal void test2() => Console.WriteLine("Internal member");
        protected void test3() => Console.WriteLine("Protected member");
        protected internal void test4() => Console.WriteLine("Protected Internal member");
        public void test5() => Console.WriteLine("Public member");

        static void Main(string[] args)
        {
            Program p = new Program();

            p.test1();
            p.test2();
            p.test3();
            p.test4();
            p.test5(); 
        }
    }
}
