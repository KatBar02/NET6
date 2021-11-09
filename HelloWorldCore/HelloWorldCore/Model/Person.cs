using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    class Person
    {
        //konstruktor aby sa to dalo písať i ako Person p1 = new Person("x","y");
        public Person()
        {
        }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public Person(string firstname, string lastname, DateTime birth)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthdate = birth;
        }

        //vlastnosti třídy
        public string FirstName { get; set; } //prvá vlastnost Person
        public string LastName { get; set; } //druhá vlastnost Person
        public DateTime Birthdate { get; set; } //tretí vlastnost Person
        public int Age() //čtvrtá vypočítaná vlastnost Person
        {
            TimeSpan diff = DateTime.Today - Birthdate;
            return (int)(diff.TotalDays / 365);
        }
        public override string ToString() // override = nededí z rodiče
        {
            return FirstName + " " + LastName;
        }
    }
}
