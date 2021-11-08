using System;

namespace HelloWorldCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Jak se jmenuješ?");

            //string name = Console.ReadLine();

            //Hello(name);
            /*

            Console.WriteLine("Napíš celé číslo:");
            string cislo = Console.ReadLine();

            int x = Vypocet(Convert.ToInt32(cislo));
            Console.WriteLine("Výsledek pro "+ cislo + ": " + x);
            */

            Console.WriteLine("Stupnů C: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledek: " + ToCelsius(x));
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

        static double ToCelsius(double degreesF)
        {
            return (degreesF + 32 )/1.8;
        }
    }
}
