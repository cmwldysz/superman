using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace test7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            while (true)
            {
                userInterface.setBg();
            }
        }
    }
    class UI {
        static UI(){
            DateTime week = new DateTime();
            string[] Day = { "日"," 一"," 二"," 三", "四"," 五", "六" };
            if (week.DayOfWeek == DayOfWeek.Saturday && week.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("今天是周{0}", Day[Convert.ToInt16(week.DayOfWeek)]);
            }
            else {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("今天不是周六周日");
            }
        }
    }
    class userInterface {
        private string num;
        public string Num {
            get => num;
            set {
                if (value == "六" || value == "日")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("今天是周{0}", value);
                    num = value;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("今天不是周六周日");
                }
            }
        }

        public static void setBg() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("今天周几：");
            userInterface ui = new userInterface();
            ui.Num = Console.ReadLine();
        }
    };
}
