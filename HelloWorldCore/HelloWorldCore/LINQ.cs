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

            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = strings.Select(slovo => slovo.ToUpper());
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        private static void NumToText()
        {
            var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result = numbers.Select(n => strings[n]);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void ukoly2(int[] numbers)
        {
            numbers = new[] { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };
            //select - transformace do nove upavené kolekce
            var result11 = numbers.Select(number => number + 10);
            //numbers = numbers.Select(number => number + 10); upraví existujúcu kolekci
            foreach (var item in result11)
            {
                Console.WriteLine(item);
            }

            //transformovat úkol 10 na ABS čísla
            var result12 = numbers
                .Select(number => Math.Abs(number))
                .OrderByDescending(number => number)
                .Take(3); ;
            Console.WriteLine("12: " + string.Join(", ", result12));
        }

        private static void ukoly1(int[] numbers)
        {
            /// 1. počet prvků v poli
            var result1 = numbers.Count();
            Console.WriteLine("počet prvku: " + result1);
            /// 2. největší hodnotu
            var result2 = numbers.Max();
            Console.WriteLine("max: " + result2);
            /// 3. nejmenší hodnotu
            var result3 = numbers.Min();
            Console.WriteLine("min: " + result3);
            /// 4. průměr
            var result4 = numbers.Average();
            Console.WriteLine("prumer: " + result4);
            /// 5. kolik obsahuje pole kladných čísel
            //var result5 = numbers.Count(number => number >= 0);
            var result5 = numbers.Where(number => number >= 0).Count();
            Console.WriteLine("pocet kladne: " + result5);
            /// 6. kolik obsahuje pole záporných čísel
            var result6 = numbers.Where(number => number < 0).Count(); ;
            Console.WriteLine("pocet zaporne: " + result6);
            /// 7. sumu všech hodnot
            var result7 = numbers.Sum();
            Console.WriteLine("suma: " + result7);
            /// 8. sumu kladných hodnot
            var result8 = numbers.Where(number => number >= 0).Sum();
            Console.WriteLine("sum kladnych: " + result8);

            // 9.
            var result9 = numbers.OrderBy(n => n).Skip(3).Sum();
            Console.WriteLine("sum všech krome prvných 3 nejmenších: " + result9);
            // 10.
            var result10 = numbers.OrderByDescending(n => Math.Abs(n)).Take(3);
            Console.WriteLine("10: " + string.Join(", ", result10));
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
