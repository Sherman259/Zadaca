using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_11._3._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>
    {
    new Ucenik("Josip","Josipovic", 978906544, 0915674321),
    new Ucenik("Marko", "Markovic",85890264,098990564),
    new Ucenik("Pero","Peric",6347893, 0973456721)
    };
            listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));
            Console.WriteLine("==========================");
            listaUcenika.ForEach(Ucenik => PlacanjeSkolarine(Ucenik));
            Console.WriteLine("==========================\n");
            listaUcenika.ForEach(Ucenik => IspisUcenika(Ucenik));

            Console.ReadKey();
        }

        private static void PlacanjeSkolarine(Ucenik ucenik)
        {
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite skolarinu (" + ucenik.Ime + " " + ucenik.Prezime + "): ");
                try
                {
                    ucenik.Racun -= int.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }

        private static void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine("Ucenik: " + ucenik.Ime + " " + ucenik.Prezime);
            Console.WriteLine("Stanje racuna: " + ucenik.Racun + " kn\n");
        }
    }
}
        
  
