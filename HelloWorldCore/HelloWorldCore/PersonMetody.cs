using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Data;
using HelloWorldCore.Model;

namespace HelloWorldCore
{
    class PersonMetody
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Martin", "Malík");
            //p.Birthdate = new DateTime(2010, 12, 02);

            //Person p4 = new Person("Martin", "Malík", new DateTime(2010, 12, 02));
            //Console.WriteLine(p4); // = Console.WriteLine(p4.ToString());

            //Car c = new Car("1a1 3636", "blue", 32000);

            //Person p5 = new Person("Sára", "Kolumbusová", new DateTime(1810, 01, 15));
            ////p5.HomeAddress = new Address("Praha","česká"); // musí byť inicializovaná/vytvorená Address pred priradením hodnoty, môže byť už v Person v konstruktore
            //p5.HomeAddress.City = "Londýn";
            //p5.HomeAddress.Street = "Londýnská";
            ////Console.WriteLine(p5);
            //PersonData.SavePerson(p5);

            //var people = PersonData.LoadPerson();
            ////Console.WriteLine(people);
            //List <string> people_name = new List<string>();

            //foreach( var p in people)
            //{
            //    people_name.Add(p.FirstName + " " + p.LastName);
            //}
            //Console.WriteLine(string.Join("," ,people_name));

            Point2D point = new Point2D(5,10);
            Point2D point2 = new Point2D(2, 4);
            //Console.WriteLine(point.ToString());
            Console.WriteLine(SumPoint(point, point2));
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

        private static string SumPoint (Point2D p1, Point2D p2)
        {
            return $"Vysledek sčítání pro body p1 = [{p1.X},{p1.Y}] a p2 = [{p2.X},{p2.Y}] je [{p1.X+p2.X},{p1.Y+p2.Y}]";
        }
    }
}
