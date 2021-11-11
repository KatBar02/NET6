using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Data
{
    class DataAccess
    {
        public static ObservableCollection<Person> people = new ObservableCollection<Person>(); //kolekce pre data People

        public static void LoadPeopleFromDB()
        {
            using (var db = new PeopleContext()) //db má vlastnosti/je typu PeopleContext, using = spojení do dtb
            {
                var peoplelist = db.People
                    .Include(x => x.HomeAddress)
                    .Include(x => x.Cars)
                    .ToList(); //list s dátami z databáze,CONNECTION je v PeopleContext, People je "najvyššia úroveň" v tých dátach PeopleContext

                people = new ObservableCollection<Person>(peoplelist); // priradenie dát do kolekce

            }
        }

        public static void SavePersonToDB(Person personToSave)
        {
            using (var db = new PeopleContext()) //db má vlastnosti/je typu PeopleContext
            {
                var dbperson = db.People.Find(personToSave.Id); // najdi v databázi v People záznam podľa PK personToSave.Id
                dbperson.FirstName = personToSave.FirstName;
                dbperson.LastName = personToSave.LastName;
                //dbperson.Birthdate = personToSave.Birthdate;

                db.SaveChanges();



            }
        }

        public static void CreatePersnon (Person personToCreate)
        {
            using (var db = new PeopleContext()) //db má vlastnosti/je typu PeopleContext
            {
                db.People.Add(personToCreate);
                db.SaveChanges();



            }
        }
    }
}
