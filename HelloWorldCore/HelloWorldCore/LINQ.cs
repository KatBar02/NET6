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
        }

        private static void LINQoperator(int[] numbers)
        {
            // number - pomenovanie jednotlivých itemov, "number >=0" podmienak na vyhodnotenie TRUE/ FALSE
            //var result = numbers.Where(number => number >= 0 && number < 100); 
            /*
            var result = numbers
                .Where(number => number >= 0)
                .Where(number => number < 100); 
            */

            // razeni, - = desc
            //var result = numbers.OrderBy(n => -n); 

            //take (top 5) a skip (preskoč prvých 5), TakeWhile (vracaj pokiaľ platí podmienka), SkipWhile (preskakuj pokilaľ platí podmienka
            //var result = numbers.SkipWhile(n => n > 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Sum, Max, Average
            //var sum = numbers.Sum();

            // first, last
            var result = numbers.OrderBy(n => n).First();



            Console.WriteLine(result);
        }
    }
}
