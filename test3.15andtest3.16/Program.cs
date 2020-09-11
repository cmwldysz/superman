using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._15andtest3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题3.15        /////////////////////
            ///
            try {
                Console.WriteLine("请输入一个你喜欢的年份：");
                int year = int.Parse(Console.ReadLine());
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0}是瑞年", year);
                }
                else {
                    Console.WriteLine("{0}不是瑞年", year);
                }
            }
            catch
            {
                Console.WriteLine("输入的年份不正确");
            }
            /////////////////////         试题3.16        /////////////////////
            ///
            Console.Write("请输入用户名：");
            string name = Console.ReadLine();
            Console.Write("请输入用户密码：");
            string pwd = Console.ReadLine();
            Console.WriteLine((name == "mr" && pwd == "mrsoft")?"登录成功":"登录失败");

            /////////////////////         编程实现107653秒是几天几小时几分钟几秒        /////////////////////
            ///
            int sumSS = 107653;
            int days = 24 * 60 * 60;
            int hhs = 60 * 60;
            int mms = 60;
            int day = sumSS / days;
            int hh = (sumSS % days) / hhs;
            int mm = (sumSS % hhs)/mms;
            int ss = sumSS%mms;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",sumSS, day, hh, mm, ss);
            /////////////////////         计算半径为4的圆的面积和周长        /////////////////////
            ///   周长c=2pir = pid   ,圆的面积s=pi*r*r

            int r = 4;
            Double pi = Math.PI;
            Double c = 2 * pi * r;
            Double s = pi * r * r;
            Console.WriteLine("半径为4的圆，周长为：{0}，面积为：{1}", c, s);

            Console.ReadKey();
        }
    }
}
