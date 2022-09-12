using System;

namespace Lesson01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite keturis skaičius");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int sumOfAll = num1 + num2 + num3 + num4;

            Console.WriteLine($"Typed numbers average is {sumOfAll / 4m}");
        }
    }
}
