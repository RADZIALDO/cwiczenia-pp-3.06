using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, sredniaArytmetyczna;

            Console.WriteLine("Podaj trzy liczby: ");
            a = inputValue();
            b = inputValue();
            c = inputValue();

            sredniaArytmetyczna = (a + b + c) / 3;
            Console.WriteLine($"Średnia arytmetyczna tych liczb wynosi: {sredniaArytmetyczna}");
            
            Console.ReadKey();
        }

        static double inputValue()
        {
            double wynik;
            while (!double.TryParse(Console.ReadLine(), out wynik)) ;
            return wynik;

        }
    }
}
