using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, dzialanie;
            bool wybor;

            do 
            {
                wybor = true;
                Console.WriteLine("KALKULATOR");
                Console.WriteLine("**********************************");

                Console.WriteLine("Podaj dwie liczby:");
                a = wczytaj();
                b = wczytaj();

                Console.WriteLine("Wybierz rodzaj działania: ");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2.Odejmowanie");
                Console.WriteLine("3.Mnożenie");
                Console.WriteLine("4.Dzielenie");

                dzialanie = wczytaj();

                switch (dzialanie)
                {
                    case 1:
                        Console.WriteLine("Wynik: ");
                        Console.Write(a + b);
                        break;
                    case 2:
                        Console.WriteLine("Wynik: ");
                        Console.Write(a - b);
                        break;
                    case 3:
                        Console.WriteLine("Wynik: ");
                        Console.Write(a * b);
                        break;
                    case 4:
                        if (b > 0)
                        {
                            Console.WriteLine("Wynik: ");
                            Console.Write(a / b);
                        }
                        else
                        {
                            Console.WriteLine("Wynik: ");
                            Console.Write($"{a}/{b}");
                        }
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego działania!");
                        wybor = false;
                        break;
                }
            } while (!wybor);
            

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
