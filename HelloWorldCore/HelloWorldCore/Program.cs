using System;
using System.IO;

namespace HelloWorldCore
{
    class MethodsDay1
    {
        //static void Main(string[] args)
        //{
        //    //DateTime date = new DateTime(2021, 08, 11, 19, 0, 0);

        //    //DateTime now = DateTime.Now;

        //    //var twoweeks = date.AddDays(14);
        //    //Console.WriteLine(twoweeks);

        //    //string day = date.DayOfWeek.ToString();
        //    //Console.WriteLine(day);

        //    //TimeSpan diff = now - date; //odčítanie dátumov, TimeSpan je datový typ

        //    Console.WriteLine("Zadej datum narození: ");
        //    DateTime birthdate = DateTime.Parse(Console.ReadLine());

        //    TimeSpan diff = DateTime.Now - birthdate;
        //    if (diff.TotalDays / 365 >= 18)
        //        Console.WriteLine("Už Vám bylo 18. Je Vám: " + (diff.TotalDays / 365));
        //    else
        //        Console.WriteLine("Je Vám míň než 18. Je Vám: " + (diff.TotalDays / 365));


        //}


        /// <summary>
        ///  komentár cez /// mimo metodu - zobrazuje sa v tooltipe na metode
        /// </summary>
        static string ConvertFtoCandPrint()
        {
            //Console.WriteLine("Zadej teplotu ve °F: ");
            //string input2 = Console.ReadLine();
            //if (input2 == "x")
            //    return input2; //ak je to X tak týmto ConvertFtoCandPrint kočí, nemusí tu byť ELSE

            //int x = int.Parse(input2);
            //Console.WriteLine("Výsledek v °C: " + ToCelsius(x)); //Console.WriteLine($"{f}°F je {c}°C");
            //return input2;


            Console.WriteLine("Zadej teplotu ve °F: ");
            string input2 = Console.ReadLine();
            try
            {
                int x = int.Parse(input2);
                Console.WriteLine("Výsledek v °C: " + ToCelsius(x)); //Console.WriteLine($"{f}°F je {c}°C");
            }
            catch (FormatException ex)
            {
                /*
                 * konkrétns výnimka na formát premennej
                 * message + nový řádek, súbor sa vytvorí tam, kde sa ten program spustil
                 * C:\Users\barto\source\repos\skolenie\HelloWorldCore\HelloWorldCore\bin\Debug\net5.0
                 */
                if (input2 != "x")
                    File.AppendAllText("errorlog.txt", DateTime.Now + ": " + ex.Message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                /*
                 * message + nový řádek, súbor sa vytvorí tam, kde sa ten program spustil
                 * C:\Users\barto\source\repos\skolenie\HelloWorldCore\HelloWorldCore\bin\Debug\net5.0
                 */
                File.AppendAllText("errorlog.txt", "General Exception: " + DateTime.Now + ": " + ex.Message + Environment.NewLine); 
            }

            return input2;
        }

        public static void Hello(string name)
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
            
            return (degreesF - 32) / 1.8;
        }


        
    }
}
