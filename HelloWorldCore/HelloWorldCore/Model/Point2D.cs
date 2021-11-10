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
        /// <summary>
        /// Přičte bod zo vstupního parametru k bodu. Výsledkem je nový bod.
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Nový bod</returns>
        public Point2D AddAnotherPoint (Point2D point)
        {
            Point2D soucetBodu = new Point2D(X + point.X, Y + point.Y);
            return soucetBodu;
        }
        /// <summary>
        /// Modifikuje tento bod, přičte hodnotu vstupního parametru point k sobě samotnému.
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(Point2D point)
        {
            X += point.X;
            Y += point.Y;
        }
    }
}
