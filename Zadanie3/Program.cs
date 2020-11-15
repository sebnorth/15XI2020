using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // program, który będzie dodawał dwie całkowite liczby podane przez użytkownika i 
            // wypisywał wynik na ekran konsoli

            Console.WriteLine("Podaj pierwszą liczbę");          
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            int liczba2;
            liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = liczba1 + liczba2;

            // Console.WriteLine("Suma podanych liczb wynosi: " + wynik );
            Console.WriteLine("Suma podanych liczb wynosi: {0}", wynik);
            // Console.WriteLine("Suma liczb {0} oraz {1} wynosi: {2}", liczba1, liczba2, wynik);

            Console.ReadKey();
        }
    }
}
