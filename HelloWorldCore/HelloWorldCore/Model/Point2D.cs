using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore.Model
{
    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Plocha()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"Vysledek pro X = {X} a Y = {Y} je {Plocha()}";
        }
    }
}
