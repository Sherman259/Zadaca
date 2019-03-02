using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj:");
            int a = int.Parse(Console.ReadLine());

            int zbrojDjeljitelja = 0;
            for (int i = 1; i < a; i++)

            {
                if (a % i == 0)
                {
                    zbrojDjeljitelja += i;
                }
            }
            if (a == zbrojDjeljitelja)
            {
                Console.WriteLine("Uneseni broj je savšen.");
            }
            else
            {
                Console.WriteLine("Uneseni broj nije savšen.");
            }
            Console.ReadKey();
        }
    }

}
