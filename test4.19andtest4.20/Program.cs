using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._19andtest4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.19        /////////////////////
            ///
            try {
                Console.Write("请输入一个数值：");
                int num = int.Parse(Console.ReadLine());
                bool state = false;
                if (num > 3)
                {
                    for (int i = 2; i < num / 2+1; i++)
                    {
                        if (num % i == 0)
                        {
                            state = true;
                            break;
                        }
                    }
                }
                Console.WriteLine("您输入的数值：{0}，{1}素数", num, state?"不是":"是");
            } catch {
                Console.WriteLine("输入的数值有误！！");
            }

            /////////////////////         试题4.20        /////////////////////
            Console.WriteLine("欢迎乘坐地铁1号线，本次列车即将从始发站出发：");
            int n = 4;// 要去达的站点数
            for (int i = 1; i <= 18; i++)
            {
                if (i == n)
                {
                    Console.WriteLine("列车即将抵达本次旅行的第{0}站,请下车的旅客做好下车准备。", i);
                    break;
                }
                else
                {
                    Console.WriteLine("列车即将抵达本次旅行的第{0}站", i);
                }
            }

            Console.ReadKey();
        }
    }
}
