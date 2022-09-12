using System;

namespace Lesson01_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celcius");
            int celc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Kelvin = {celc + 273}");
            Console.WriteLine($"Farenheit = {celc * 18 / 10m + 32}");
        }
    }
}
