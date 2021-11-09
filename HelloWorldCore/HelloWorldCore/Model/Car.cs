using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    class Car
    {
        public string PlateNumber { get; set; } //prvá vlastnost Car
        public string Color { get; set; } //2 vlastnost Car
        public double Kilometers { get; set; } //3 vlastnost Car
        public void AddKilometers(double km)  //4 vlastnost Car
        {
            Kilometers += km;
        }
        public void ZeroKilometers() 
        {
            Kilometers = 0;
        }

    }
}
