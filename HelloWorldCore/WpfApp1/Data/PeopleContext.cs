using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Data
{
    class PeopleContext : DbContext
    {
        // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio
        
        public DbSet<Person> People { get; set; } // People bude ako tabuľka na základe Person triedy
        public DbSet<Car> Cars { get; set; } // Cars bude ako tabuľka na základe Car triedy
        public DbSet<Address> Addresses { get; set; } // Addresses bude ako tabuľka na základe Address triedy

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer($"Server=(LocalDB)\\MSSQLLocalDB;Database=peopledb");

        //SQL Server
        //1. mať napísaný class PeopleContext : DbContext // vytvorenie mapovania na třídy a databázu
        //2. Package MAnager Console: Add-Migration InitialCreatePEOPLEDB // vytvorenie mygračných súborov
        //3. Package MAnager Console: Update-Database //spustenie migračného skriptu nad databázou

        //SQLite
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //  => options.UseSqlite($"Data Source = peopledb.db");
        //remove migration v PM Console
        //add-migration initlite
    }
}
