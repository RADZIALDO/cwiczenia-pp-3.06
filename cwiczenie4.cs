using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ćwiczenie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, y;

            Console.WriteLine("Podaj cztery liczby: ");
            a = wczytaj();
            b = wczytaj();
            c = wczytaj();
            d = wczytaj();

            if(b == 0 || d == 0)
            {
                Console.WriteLine("Brak rozwiązań");
            }
            else
            {
                if(b == d)
                {
                    y = b;
                    x = a + c;
                    Console.WriteLine($"Licznik(x):   {x}");
                    Console.WriteLine($"Mianownik(y): {y}");
                }
                else
                {
                    y = b * d;
                    c *= b;
                    a *= d;
                    x = a + c;

                    Console.WriteLine($"Licznik(x):   {x}");
                    Console.WriteLine($"Mianownik(y): {y}");
                }
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
