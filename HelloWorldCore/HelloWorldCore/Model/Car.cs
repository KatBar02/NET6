using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    public class Car
    {
        public Car()
        {
        }
        public Car(string platenumber, string color ,double kilometers)
        {
            PlateNumber = platenumber;
            Color = color;
            Kilometers = kilometers;
        }
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
        public override string ToString() // override = nededí z rodiče
        {
            return PlateNumber + ", " + Kilometers + " km";
        }
    }
}
