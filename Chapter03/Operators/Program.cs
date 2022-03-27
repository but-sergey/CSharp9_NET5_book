using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            Console.WriteLine($"a is {a}, b is {b}");

            int c = 3;
            int d = ++c;
            Console.WriteLine($"c is {c}, d is {d}");
        }
    }
}
