using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._11andtest4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.11        /////////////////////
            int i = 1, sum = 0;
            while (sum <= 500)
            {
                sum += i;
                i += 2;
            }
            Console.WriteLine("满足1+3+ 5 + ... + n > 500的最小正整数n为：{0}", i);

            /////////////////////         试题4.12        /////////////////////
            ///
            Random rNum = new Random();
            int number = rNum.Next(1, 200);
            Console.WriteLine("---------   猜数字小游戏  --------\n\n");
            Console.Write("请输入你猜的数字：");
            int iNum = int.Parse(Console.ReadLine());
            while (iNum != number)
            {
                if (iNum > number)
                {
                    Console.Write("太大，请重新输入：");
                }
                else
                {
                    Console.Write("太小，请重新输入：");
                }
                iNum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("恭喜你，你赢了，猜中的数字是：{0}", iNum);
            Console.WriteLine("\n\n---------   游戏结束  --------");

            Console.ReadKey();
        }
    }
}
