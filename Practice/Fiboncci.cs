using System;

namespace Practice
{
    class Fiboncci
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {

                int a = 0, b = 1, c = 1;

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(c + "\t");
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write("\n");

            }
        }
    }
}
