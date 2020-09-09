using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用XXX登录系统");
            Console.Write("请输入您的年龄:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("您当前的年龄为{0}符合登录条件。", age);
            }
            else
            {
                Console.WriteLine("未满18岁禁止登录本系统");
            }
            Console.ReadKey();
        }
    }
}
