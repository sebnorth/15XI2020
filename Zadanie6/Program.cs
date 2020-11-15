using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            poprawa:
            
            try
            {
                Console.WriteLine("Podaj x: ");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj y: ");
                int y = int.Parse(Console.ReadLine());

                if (y == 0)
                {
                    throw new DivideByZeroException("Proszę podać wartość y różną od zera!!!");
                }

                int iloraz = x / y;

                Console.WriteLine("iloraz x przez y wynosi: {0}", iloraz);
            }
            catch (DivideByZeroException uchwyt)
            {

                Console.WriteLine(uchwyt.Message);
                goto poprawa;
                // throw;

            }
            catch (Exception uchwyt) {

                Console.WriteLine(uchwyt.Message);
            }

            Console.WriteLine("Program rusza dalej...");
            Console.ReadKey();
        }
    }
}
