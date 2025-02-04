﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    public class Person
    {
        //konstruktor aby sa to dalo písať i ako Person p1 = new Person("x","y");
        public Person()
        {
            HomeAddress = new Address();
        }
        public Person(string firstname, string lastname)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
        }
        public Person(string firstname, string lastname, DateTime birth)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
            Birthdate = birth;
        }

        //vlastnosti třídy
        public int Id { get; set; }
        [MaxLength(200)]
        public string FirstName { get; set; } //prvá vlastnost/property Person
        [MaxLength(200)]
        public string LastName { get; set; } //druhá vlastnost Person
        public Address HomeAddress { get; set; } = new Address(); // vlastnos typu třídy ADDRESS 
                                                                  // = new Address(); je ekvivalent k vytváraniu v každom jednom konstruktore, ADDRESS bude vždy inicializovaná

        public List<Car> Cars { get; set; } = new List<Car>();  //aby mohla mať jedna osoba viac áut

        [NotMapped] // anotace pre ignorovanie pri prenose do DTB, z property nebude nový stĺpec
        public int CarsCount { get { return Cars.Count(); } } //nie je metoda pretože to chcem v DataGrif v hlavnom okne, len na čítanie

        public DateTime Birthdate { get; set; } //tretí vlastnost Person
        public int Age() //čtvrtá vypočítaná vlastnost Person
        {
            TimeSpan diff = DateTime.Today - Birthdate;
            return (int)(diff.TotalDays / 365);
        }
        public override string ToString() // override = nededí z rodiče
        {
            return FirstName + " " + LastName + " Adresa: " + HomeAddress.City + ", " + HomeAddress.Street;
        }
        
    }
}
