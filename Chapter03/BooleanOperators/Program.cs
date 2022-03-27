﻿using System;

namespace BooleanOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool a = true;
            bool b = false;
            /*
            Console.WriteLine($"AND   | a     | b     ");
            Console.WriteLine($"a     | {a & a,-5} | {a & b,-5} ");
            Console.WriteLine($"b     | {b & a,-5} | {b & b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"OR    | a     | b     ");
            Console.WriteLine($"a     | {a | a,-5} | {a | b,-5} ");
            Console.WriteLine($"b     | {b | a,-5} | {b | b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"XOR   | a     | b     ");
            Console.WriteLine($"a     | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"b     | {b ^ a,-5} | {b ^ b,-5} ");
            Console.WriteLine();
            */

            Console.WriteLine($"a & DoStuff() = {a & DoStuff()}");
            Console.WriteLine($"b & DoStuff() = {b & DoStuff()}");
            Console.WriteLine();
            Console.WriteLine($"a && DoStuff() = {a && DoStuff()}");
            Console.WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            Console.WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
