using System;
using System.IO;
using System.Xml;

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

            var population = 66_000_000;
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;

            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            var file1 = File.CreateText(@"D:\something.txt");
            StreamWriter file2 = File.CreateText(@"D:\something.txt");
        }
    }
}
