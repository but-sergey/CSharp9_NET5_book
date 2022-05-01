using System;

namespace CheckingForOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int x = int.MaxValue - 1;
                Console.WriteLine($"Initial value: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
            }
        }
    }
}
