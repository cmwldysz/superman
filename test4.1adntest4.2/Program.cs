using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._1adntest4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.1        /////////////////////
            ///
            try {
                Console.WriteLine("请输入一个数值：");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("输入的是一个偶数");
                }
                else
                {
                    Console.WriteLine("输入的是一个奇数");
                }
            } catch
            {
                Console.WriteLine("输入的内容为非数字");
            }
            /////////////////////         试题4.2        /////////////////////
            Console.Write("请输入银行卡密码：");
            string pwd = Console.ReadLine();
            if (pwd == "404328")
            {
                Console.WriteLine("密码正确，您可以取钱了……");
            }
            else {
                Console.WriteLine("密码错误");
            }

            Console.ReadKey();
        }
    }
}
