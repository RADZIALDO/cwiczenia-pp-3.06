using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ćwiczenie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double P, Obw, r;
            Console.WriteLine("Podaj pole koła: ");
            P = wczytaj();
            r = Math.Sqrt(P/Math.PI);
            Obw = 2*Math.PI * r;
            Console.WriteLine($"Obwód wynosi: {Obw}");

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
