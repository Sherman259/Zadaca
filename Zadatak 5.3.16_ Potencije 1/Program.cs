﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._16__Potencije_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Potencija broja 2 manje od 1000 su:");

            for (int i = 1; i <= 1000; i *= 2)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }

    }
}
