using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCore.Model;

namespace HelloWorldCore
{
    class PointMath
    {
        //static void Main(string[] args)
        //{
        //    Point2D point = new Point2D(5, 10);
        //    Point2D point2 = new Point2D(2, 4);
        //    //Console.WriteLine(point.ToString());
        //    //Console.WriteLine(SumPoint(point, point2));
        //    Console.WriteLine($"Vysledek sčítání pro body p1 = [{point.X},{point.Y}] a p2 = [{point2.X},{point2.Y}] je [{SumPoint(point, point2).X},{SumPoint(point, point2).Y}]");
        //}

        private static Point2D SumPoint(Point2D p1, Point2D p2)
        {
            
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;
            return new Point2D(x,y);
                
        }
    }
}
