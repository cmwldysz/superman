using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._3andtest4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.3        /////////////////////
            ///
            try {
                Console.Write("请输入需要报销的金额：");
                double money = double.Parse(Console.ReadLine());
                if (money < 5000)
                {
                    Console.WriteLine("正常报销");
                }
                else {
                    Console.WriteLine("不符合规定报销");
                }
            }
            catch
            {
                Console.WriteLine("输入的金额不正确");
            }


            /////////////////////         试题4.4        /////////////////////
            ///
            Console.WriteLine("请输入您要拨打的电话号码：");
            string phone = Console.ReadLine();
            if (phone == "4006751066")
            {
                Console.WriteLine("电话正在接通，请等待……");
            }
            else {
                Console.WriteLine("拨打的号码不存在");
            }


            Console.ReadKey();
        }
    }
}
