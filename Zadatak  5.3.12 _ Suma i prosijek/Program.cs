using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak__5._3._12___Suma_i_prosijek
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            float prosjek;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(" Unesite {0}. prirodan broj:", i.ToString());
                suma += int.Parse(Console.ReadLine());
            }
            prosjek = (float)suma / 5;

            Console.Write("Suma = {0} \nProsjek = {0}", suma, prosjek);
            Console.ReadKey();




        }
    }
}
