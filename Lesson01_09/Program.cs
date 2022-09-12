using System;
using System.Reflection.Metadata;

namespace Lesson01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sign");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{s}{s}{s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s} {s}");
            Console.WriteLine($"{s}{s}{s}");

            string yourSign = "";
            Console.WriteLine("Enter a sign");
            yourSign = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", yourSign);
            Console.WriteLine("{0} {0}", yourSign);
            Console.WriteLine("{0} {0}", yourSign);
            Console.WriteLine("{0} {0}", yourSign);
            Console.WriteLine("{0}{0}{0}", yourSign);
        }
    }
}
