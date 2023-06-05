using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            Console.Write("Podaj liczbę: ");
            liczba = wczytaj();

            liczba %= 10;

            Console.Write($"Ostatnia cyfra to: {liczba}");
            

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
