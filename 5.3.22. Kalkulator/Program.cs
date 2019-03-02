using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._22.Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            string odgovor = "D";


            while (odgovor == "D" || odgovor == " D")
            {
                Console.Write("Unesite 1. broj;");
                a = float.Parse(Console.ReadLine());
                Console.Write("Unesite 2. broj;");
                b = float.Parse(Console.ReadLine());
                Console.Write("Unesite racunsku operaciju (+, -, *, /):");
                    operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0}", a + b);
                        break;

                    case "-":
                        Console.WriteLine("Razlika: {0}", a - b);
                        break;

                    case "*":
                        Console.WriteLine("Umnozak: {0}", a * b);
                        break;
                    case "/":
                        Console.WriteLine("Kvocijent: {0}", a / b);
                        break;
                    default:
                        Console.WriteLine("Nepoznata racunska operacija!");
                        break;
                }
                Console.Write("zelite li ponovo računati (D/N)?");
                odgovor = Console.ReadLine();
            }







        }
    }
}
