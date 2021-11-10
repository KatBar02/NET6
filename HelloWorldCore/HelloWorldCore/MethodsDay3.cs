using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    class MethodsDay3
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine(DayNameCZ(2));
        //    //Console.WriteLine(DayNameArrayCZ(2));
        //    //Console.WriteLine(DayNameListCZ(2));
        //    //Console.WriteLine(IsWorkDay(2));
        //    //Console.WriteLine(DayNumberCZ("štvrtok"));
        //    //Console.WriteLine(DayNumberArrayCZ("štvrtok"));
        //    Console.WriteLine(DayNumberListCZ("štvrtok"));


        //}

        public static string DayNameCZ(int dayNmbr)
        {
         
            switch (dayNmbr)
            {
                case 1: 
                    return "pondelok";
                case 2: 
                    return "utorok";
                default: 
                    return "číslo nereprezentuje deň v týždni";
            }
        }

        public static bool IsWorkDay(int dayNmbr)
        {

            switch (dayNmbr)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return true;
                case 6:
                    return false;
                default:
                    throw new Exception("číslo dňa musí byť 1-7");
            }
        }

        public static string DayNameArrayCZ(int dayNmbr)
        {

            string[] days = new[] { "pondelok", "utorok", "streda"};
            return days[dayNmbr-1];
        }

        public static string DayNameListCZ(int dayNmbr)
        {

            List<string> days = new List<string> { "pondelok", "utorok", "streda" };
            return days[dayNmbr - 1];
        }

        public static int DayNumberCZ(string dayName)
        {
            dayName = dayName.ToLower();

            switch (dayName)
            {
                case "pondelok":
                    return 1;
                case "utorok":
                    return 2;
                case "streda":
                    return 3;
                case "štvrtok":
                    return 4;
                case "piatok":
                    return 5;
                case "sobota":
                    return 6;
                case "nedeľa":
                    return 7;
                default:
                    return 0;
            }
        }

        public static int DayNumberArrayCZ(string dayName)
        {
            string[] days = new[] { "pondelok", "utorok", "streda", "štvrtok", "piatok" };
            dayName = dayName.ToLower();

            for (int i = 0; i < days.Count(); i++)
            {
                if (days[i] == dayName)
                    return i + 1;

            }
            return 0;
        }

        public static int DayNumberListCZ(string dayName)
        {
            List<string> days = new List<string> { "pondelok", "utorok", "streda", "štvrtok", "piatok" };
            //return days.BinarySearch(dayName.ToLower()) + 1;
            return days.IndexOf(dayName.ToLower()) + 1;

        }
    }
}
