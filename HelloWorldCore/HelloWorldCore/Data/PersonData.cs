using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;

namespace HelloWorldCore.Data
{
    public class PersonData
    {
        //static string PersonDataFile { get; set; } // statická položka, globální proměnná
        const string personDataFile = "people.txt"; //druhá možnosť

        /// <summary>
        /// metoda pro uložení/připojení jedne osoby do souboru
        /// </summary>
        public static void SavePerson(Person person)
        {
            var line = $"{person.FirstName};{person.LastName};{person.Birthdate};{person.HomeAddress.City};{person.HomeAddress.Street}";
            line += Environment.NewLine;
            File.AppendAllText(personDataFile, line);
        }

        public static List<Person> LoadPerson(string file = "file.txt")
        {
            List<Person> people = new List<Person>();       //List<int> numbers = new List<int>(); = var numbers = new List<int>();

            var lines = File.ReadAllLines(file);

            foreach(var line in lines)
            {
                var items = line.Split(';');
                Person p = new Person(items[0],items[1],DateTime.Parse(items[2])) ;
                p.HomeAddress.City = items[3];
                p.HomeAddress.Street = items[4];

                people.Add(p);
            }

            return people;
        }
    }
}
