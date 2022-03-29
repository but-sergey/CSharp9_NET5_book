using System;

namespace SelectionStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            if(args.Length == 0)
            {
                Console.WriteLine("There are no argument.");
            }
            else
            {
                Console.WriteLine("There is at least one argument.");
            }
            */

            object o = "3";
            int j = 4;

            if(o is int i)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply!");
            }
        }
    }
}
