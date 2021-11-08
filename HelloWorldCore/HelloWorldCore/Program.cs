using System;

namespace HelloWorldCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.
            Console.WriteLine("Jak se jmenuješ?");

            string name = Console.ReadLine();

            Hello(name);
            */
            /* 2.
            
            Console.WriteLine("Napíš celé číslo:");
            string cislo = Console.ReadLine();

            int x = Vypocet(Convert.ToInt32(cislo));
            Console.WriteLine("Výsledek pro "+ cislo + ": " + x);
            */

            ConvertFtoCandPrint();
        }


        /// <summary>
        ///  komentár cez /// mimo metodu - zobrazuje sa v tooltipe na metode
        /// </summary>
        private static void ConvertFtoCandPrint()
        {
            Console.WriteLine("Zadej teplotu ve °F: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek v °C: " + ToCelsius(x));
        }

        static void Hello(string name)
        {
            string name5p = name;

            if (name == "Lukáš")
            {
                name5p = "Lukáši";
            }
            else if (name == "Karel")
            {
                name5p = "Karle";
            }
            else if (name == "Petr")
            {
                name5p = "Petře";
            }
            else
            {
                name5p += ", omlouvám se, ale tvoje jméno neumím skloňovat.";
            }

            string pozdrav = "Ahoj " + name5p;

            Console.WriteLine(pozdrav);
        }
        static int Vypocet(int cislo)
        {          
            int result = cislo * 2 + 10;
            //int x = 55;
            //Console.WriteLine("x: " + x);
            return result;
        }

        /// <summary>
        /// popis i s komentárom k output hodnotám
        /// </summary>
        /// <param name="degreesF"></param>
        /// <returns>temperature in C</returns>
        static double ToCelsius(double degreesF)
        {
            
            return (degreesF + 32 )/1.8;
        }
    }
}
