using System;

namespace Lesson01_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give A, B, C a number");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(A + B) * C}, {(A * C) + (B * C)}");


        }
    }
}
