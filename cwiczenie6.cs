using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Podaj boki trójkąta równobocznego: ");

            a = wczytaj();
            b = wczytaj();
            c = wczytaj();

            if(a == b && a == c && b == c)
            {
                Console.WriteLine("Można zbudować trójkąt równoboczny");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta równobocznego");
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
