using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCore
{
    class MethodsDay3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayNameCZ(2));
            Console.WriteLine(DayNameArrayCZ(2));
            Console.WriteLine(DayNameListCZ(2));
            Console.WriteLine(IsWorkDay(2));


        }

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
    }
}
