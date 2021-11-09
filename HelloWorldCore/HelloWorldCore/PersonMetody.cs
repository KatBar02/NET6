using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;

namespace HelloWorldCore
{
    class PersonMetody
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            c1.PlateNumber = "1a1 3636";
            c1.Color = "blue";
            c1.Kilometers = 21455.21;

            
        }

        private static void StarsiOsoba()
        {
            Person p1 = new Person(); //konstruktor pre vytvorenie instance/objektu Person

            p1.FirstName = "John";
            p1.LastName = "Doe";
            p1.Birthdate = new DateTime(1994, 05, 06);
            int age1 = p1.Age();

            Person p2 = new Person(); //konstruktor pre vytvorenie instance/objektu Person

            p2.FirstName = "John";
            p2.LastName = "Smith";
            p2.Birthdate = new DateTime(1985, 01, 22);
            int age2 = p2.Age();

            Person oldest = p1.Age() >= p2.Age() ? p1 : p2;
            Console.WriteLine("Nejstarší je: " + oldest.FirstName + " " + oldest.LastName);
        }
    }
}
