using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    class LINQ
    {

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, -30, 4, 20, 256, -45, 99 };

            var result = numbers.Where(number => number >= 0); //number - pomenovanie jednotlivých itemov, "number >=0" podmienak na vyhodnotenie TRUE/FALSE

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


    }
}
