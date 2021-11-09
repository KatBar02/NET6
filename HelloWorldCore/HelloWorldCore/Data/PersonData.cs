using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;

namespace HelloWorldCore.Data
{
    class PersonData
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
    }
}
