using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    class Address
    {
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }
        public Address()
        {
            //ctor pre auto vyytvorenie prázneho konstruktora
        }
        public string Street { get; set; }
        public string City { get; set; } 
    }
}
