using System;

namespace CastingConverting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d);

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");
            */

            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");
        }
    }
}
