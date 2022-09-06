using System;

namespace Lesson01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Labas Pasauli! 3 + 5 = {3 + 5}"); // 1 vietoje
            Console.WriteLine(String.Format("3 + 5  = {0}", 3 + 5)); // 2 vietoje 
            Console.WriteLine("Labas Pasauli! = {3 + 5}");
            Console.WriteLine("Labas Pasauli!");
            Console.WriteLine(3 + 5);
            Console.WriteLine("\"3 +  5 = " + "5" + (3+5)); // 3 vietoje

            string inputText;
            Console.WriteLine("Kokia Jūsų mėgstamiausia spalva");
            inputText = Console.ReadLine();
            Console.WriteLine($"Mano irgi {inputText}!");


        }
    }
}
