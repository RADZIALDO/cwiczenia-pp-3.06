using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double BMI, w, h;

            Console.WriteLine("Podaj wagę[kg]: ");
            w = wczytaj();
            Console.WriteLine("Podaj wzrost[m]: ");
            h = wczytaj();

            BMI = w/Math.Pow(h,2);

            Console.WriteLine($"Twoje BMI wynosi: {BMI}");

            Console.ReadKey();
        }

        static double wczytaj()
        {
            double wynik;
            while (!double.TryParse(Console.ReadLine(), out wynik)) ;
            return wynik;
        }
    }
}
