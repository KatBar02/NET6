using System;
using System.IO;

namespace HelloWorldCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5.
             * 
             */
            //string name = "   Martin Novák   ";

            //if (!string.IsNullOrEmpty(name)) // ! pred výrazom je negace
            //{
            //    //mam jmneo
            //}

            //Console.WriteLine("Meno nie je prazdne: " + !string.IsNullOrEmpty(name));

            //string name_trim = name.Trim();

            //Console.WriteLine(name);
            //Console.WriteLine(name_trim);

            //string[] items = name_trim.Split(" ");
            //string firstname = items[0];
            //string lastname = items[1];
            //Console.WriteLine("firstname: " + firstname + ", lastname:" + lastname);


            //bool Martin = name.Contains("martin", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine("Obsahuje Martina: " + Martin);
            ////alebo:
            //if(name.ToLower() == "martin")
            //{

            //}
            try
            {
                string input_end = "";
                Console.WriteLine("Program končí napsáním: X");
                Console.WriteLine("Jak se jmenuješ?");
                string name = Console.ReadLine().Trim();
                Console.WriteLine("Kolik ti je let? (int)");
                int age = int.Parse(Console.ReadLine().Trim());

                while (input_end != "x")
                {                                     
             
                    string name_age = "Jméno: " + name + ", Věk: " + age.ToString();

                    File.AppendAllText("name.txt", DateTime.Now + ": " + name_age + Environment.NewLine);
                }

            }
            catch (FormatException ex)
            {
                
                    
            }

        }


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
            
            return (degreesF - 32) / 1.8;
        }
    }
}
