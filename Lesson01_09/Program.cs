using System;

namespace Lesson01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sign");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{s}{s}{s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s}{s}{s}");
        }
    }
}
