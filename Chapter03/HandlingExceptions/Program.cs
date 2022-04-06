using System;

namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch
            {
            }
            Console.WriteLine("After parsing");
        }
    }
}
