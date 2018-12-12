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

            int valbase;
            Console.WriteLine("inserisci una base per convertire il numero");
            do
            {
                valbase = Convert.ToInt32(Console.ReadLine());

            } while (valbase != 2 && valbase != 8 && valbase != 16);

            while (num > 1)
            {
                int resto = num % valbase;
                risultato = Convert.ToString(resto) + risultato;
                num = num / valbase;
            }

            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero convertito è {risultato}");

            Console.ReadLine();
        }
    }
}
