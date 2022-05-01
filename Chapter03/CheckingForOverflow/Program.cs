using System;

namespace CheckingForOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            try
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
            catch (OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exception.");
            }
            */

            int y = int.MaxValue + 1;
        }
    }
}
