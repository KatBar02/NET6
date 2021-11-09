using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    class Person
    {
        public string FirstName { get; set; } //prvá vlastnost Person
        public string LastName { get; set; } //druhá vlastnost Person
        public DateTime Birthdate { get; set; } //tretí vlastnost Person
        public int Age() //čtvrtá vypočítaná vlastnost Person
        {
            TimeSpan diff = DateTime.Today - Birthdate;
            return (int)(diff.TotalDays / 365);
        }
    }
}
