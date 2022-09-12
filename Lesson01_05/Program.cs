using System;

namespace Lesson01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PARAŠYTI PROGRAMĄ KURI
            IŠVEDA DVIEJŲ VARTOTOJO
            ĮVEDAMŲ SKAIČIŲ
            SANDAUGA, DALYBĄ, 
            SUMĄ, SKIRTUMĄ            
            */

            Console.WriteLine("Įveskite pirmą skaičių nuo 1 iki 9");          
            int pirmą = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių nuo 1 iki 9");
            int antrą = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dviejų vartotojo įvedamų skaičių suma " + (pirmą + antrą));
            Console.WriteLine("Dviejų vartotojo įvedamų skaičių sandauga " + (pirmą * antrą));
            Console.WriteLine("Dviejų vartotojo įvedamų skaičių dalyba " + (pirmą / antrą));
            Console.WriteLine("Dviejų vartotojo įvedamų skaičių skirtumas " + (pirmą - antrą));
        }
    }
}
