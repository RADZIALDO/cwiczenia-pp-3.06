using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, r, a = 0, b = 0;


            Console.WriteLine("Podaj współrzędne punktu P: ");
            Console.WriteLine($"x = {x = wczytaj()}");
            Console.WriteLine($"y = {y = wczytaj()}");
            Console.WriteLine($"Podaj promień r = {r = wczytaj()}");

            if(((Math.Pow((x - a), 2)) + (Math.Pow((y - b),2))) <= Math.Pow(r,2))
            {
                Console.WriteLine("Punkt P leży w obrębie koła");
            }
            else
            {
                Console.WriteLine("Punkt P nie leży w obrębie koła");
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
