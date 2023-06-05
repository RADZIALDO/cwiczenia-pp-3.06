using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Podaj x: ");
            x = wczytaj();
            

            if(x < -1)
            {
                Console.WriteLine($"y = -1");
            }else if(x >= -1 && x <= 1)
            {
                Console.WriteLine($"y = 0");
            }else if(x > 1)
            {
                Console.WriteLine($"y = 1");
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
