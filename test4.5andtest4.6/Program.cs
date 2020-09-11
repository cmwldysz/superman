using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace test4._5andtest4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.5        /////////////////////
            ///
            Console.Write("请输入关卡：");
            string num = Console.ReadLine();
            if (num == "1" || num == "2" || num == "3")
            {
                Console.WriteLine("当前进入第 {0} 关……", num);
            }
            else {
                Console.WriteLine("请输入正确的关数，当前游戏只有3关");
            }
            /////////////////////         试题4.6        /////////////////////
            ///
            try {
                Console.Write("请输入当前学生的成绩：");
                double score = double.Parse(Console.ReadLine());
                string result;
                if (score >= 85) {
                    result = "优";
                }
                else if (score >= 75 && score < 85)
                {
                    result = "良";
                }
                else if (score >= 60 && score < 75)
                {
                    result = "中";
                }
                else
                {
                    result = "差";
                }
                Console.WriteLine("成绩为{0}的时候成绩等级为：{1}", score, result);
            } catch {
                Console.WriteLine("输入的成绩不正确");
            }

            Console.ReadKey();
        }
    }
}
