using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";

            Console.WriteLine($"{name} is {height} metres tall.");

            //int length1 = name.Length;
            int length2 = ((string)name).Length;

            Console.WriteLine($"{name} has {length2} characters.");

            dynamic anotherName = "Ahmed";

            int length = anotherName.Length;

            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 4.99M;
            string fruit = "Apples";
            char letter = 'Z';
            bool happy = true;
        }
    }
}
