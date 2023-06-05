using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj dwie liczby: ");
            a = wczytaj();
            b = wczytaj();

            if(a > b)
            {
                Console.WriteLine($"Większa liczba to a = {a}");
            }
            else if(a < b)
            {
                Console.WriteLine($"Większa liczba to b = {b}");
            }
            else
            {
                Console.WriteLine("Liczby są równe");
            }

            Console.ReadKey();
        }
        static int wczytaj()
        {
            int wynik;
            while (!int.TryParse(Console.ReadLine(), out wynik)) ;
            return wynik;
        }
    }
}
