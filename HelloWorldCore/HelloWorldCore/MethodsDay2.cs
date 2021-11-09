using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    class MethodsDay2
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("Zadej datum narození: ");
            //DateTime birthdate = DateTime.Parse(Console.ReadLine()); ;
            //Console.WriteLine("Je Vám: " + YourAge(birthdate) + " let");

            OldestPerson();

        }

        private static void OldestPerson()
        {
            string max_name = "";
            int max_age = 0;

            foreach (var line in File.ReadLines("lide.txt"))
            {
                string[] items = line.Split(';');
                string name = items[0];
                string age_s = items[1];
                int age = int.Parse(age_s);

                if (max_age < age)
                {
                    max_age = age;
                    max_name = name;
                }

            }
            Console.WriteLine($"Nejstarčí je{max_name} s věkem {max_age}");
        }

        static int YourAge(DateTime birthdate)
        {

            TimeSpan diff = DateTime.Now - birthdate;
            return (int)(diff.TotalDays / 365);
        }

        static int HighestInt(int x, int y)
        {
            return Math.Max(x, y);
            //return (x > y ? x : y); // if x > y vrať x else y
        }

        static bool IsEndingOva(string lastname)
        {
            return lastname.EndsWith("ová");
        }

        
    }
}
