using System;

namespace SelectionStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("There are no argument.");
            }
            else
            {
                Console.WriteLine("There is at least one argument.");
            }
        }
    }
}
