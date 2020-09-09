using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用10086充值业务");
            Console.Write("请输入充值金额：");
            string money = Console.ReadLine();
            Console.WriteLine("充值成功，您本次充值" + money + "元。");
            Console.ReadKey();
        }
    }
}
