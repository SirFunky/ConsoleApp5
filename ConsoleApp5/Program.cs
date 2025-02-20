using System;

namespace ConsoleApp5
{
    class Program
    {
        static void MyMethod(ref int y)
        {
            Console.WriteLine("MyMethood 1:" + y);
            y = 42;
            Console.WriteLine("MyMethood 2;" + y);
        }
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine("Main 1:" + x);
            MyMethod(ref x);
            Console.WriteLine("Main2:" + x);
        }
    }
}
