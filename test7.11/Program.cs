using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._11
{
    class Test {
        public static int waterYield = 0;//储水量
        //注水
        public static void AddWater() {
            if (waterYield >= 100){
                Console.WriteLine("水已满，无法在注水");
            } else {
                waterYield += 10;
                Console.WriteLine("已注入10升水，当前已注入{0}升水", waterYield);
            }
        }
        //放水
        public static void MinusWater() {
            if (waterYield <= 0)
            {
                Console.WriteLine("水已放空无法继续放水");
            }
            else
            {
                waterYield -= 10;
                Console.WriteLine("已放10升水，当前还剩{0}升水", waterYield);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (Test.waterYield < 100)
            {
                //注水
                Test.AddWater();
            }
            while (Test.waterYield >0)
            {
                //放水
                Test.MinusWater();
            }
            Console.ReadKey();
        }
    }
}
