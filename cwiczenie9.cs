using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Przed zamianą");
            Console.Write("a = ");
            a = wczytaj();
            Console.Write("b = ");
            b = wczytaj();
            Console.Write("c = ");
            c = wczytaj();

            a = a + b;
            b = a - b;
            a = a - b;
            a = a + c;
            c = a - c;
            a = a - c;

            Console.WriteLine("Po zamianie");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");

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
