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
            using (var db = new PeopleContext()) //db má vlastnosti/je typu PeopleContext
            {
                var peoplelist = db.People
                    .Include(x => x.HomeAddress)
                    .Include(x => x.Cars)
                    .ToList(); //list s dátami z databáze,CONNECTION je v PeopleContext, People je "najvyššia úroveň" v tých dátach PeopleContext

                people = new ObservableCollection<Person>(peoplelist); // priradenie dát do kolekce

            }
        }
    }
}
