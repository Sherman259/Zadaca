﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._14_Neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Neparni brojevi iz intervala [ 1, 10] su:");

            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write("{0},", i. ToString());
            }
            Console.ReadKey();


        }
    }
}
