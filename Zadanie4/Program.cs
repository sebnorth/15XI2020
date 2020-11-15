using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            // program sprawdza, czy liczba jest parzysta
            Console.WriteLine("Podaj liczbę");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest PARZYSTA", n);
            }

            else

            {

                Console.WriteLine("Liczba {0} jest NIEPARZYSTA", n);
            }

            Console.ReadKey();
        }
    }
}
