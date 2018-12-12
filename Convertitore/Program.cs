using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = "";
            int num = 0;
            Console.WriteLine("inserisci un numero da convertire in binario");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero binario è {risultato}");

            Console.WriteLine();


            int valbase = 0;
            Console.WriteLine("scegli una base tra 8 e 16 da convertire il numero");
            do
            {
                valbase = Convert.ToInt32(Console.ReadLine());
                if (valbase != 8 && valbase != 16)
                {
                    Console.WriteLine("reinserisci una base scegliendo tra 8 e 16");
                }
            } while (valbase != 8 && valbase != 16);

            risultato = "";
            num = 0;
            while (num > 0)
            {
                int resto = num % valbase;
                risultato = Convert.ToString(resto, valbase) + risultato;
                num = num / valbase;
            }
            Console.WriteLine($"il numero convertito in base {valbase} è {risultato}");
            Console.ReadLine();
        }
    }
}
