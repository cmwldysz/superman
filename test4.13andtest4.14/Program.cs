using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._13andtest4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.13        /////////////////////
            ///
            try
            {
                Console.Write("请输入一个大于1的数值：");
                int n = 1, num, factorial = 1;
                num = int.Parse(Console.ReadLine());
                if (num > 1)
                {
                    do
                    {
                        factorial = factorial * n;
                        Console.WriteLine(factorial);
                        n++;
                    } while (n <= num);
                    Console.WriteLine("数值{0}的阶乘为：{1}", num, factorial);
                }
                else
                {
                    Console.WriteLine("输入的数值不正确！！！");
                }
            }
            catch
            {
                Console.WriteLine("输入的数值不正确！");
            }

            /////////////////////         试题4.14        /////////////////////
            ///
            try
            {
                int num1 = 3, num2 = 5, num3 = 7, iNum;
                Console.WriteLine("请选择饮料的价格：（有{0}元、{1}元、{2}元）", num1, num2, num3);
                iNum = int.Parse(Console.ReadLine());
                int i = 1;
                if (iNum == num1 || iNum == num2 || iNum == num3)
                {
                    Console.WriteLine("请开始投币");
                    do
                    {
                        Console.WriteLine("已投{0}个币，请继续投币……", i);
                        i++;
                    } while (i < iNum);
                    Console.WriteLine("投币成功，请拿走饮料");
                }
                else
                {
                    Console.WriteLine("没有{0}元的饮料", iNum);
                }
            }
            catch
            {
                Console.WriteLine("输入的数值不正确！");
            }

            /////////////////////         求两个数的最大公约数和最小公倍数        /////////////////////
            ///
            try
            {
                Console.WriteLine("计算两个正整数的最大公约数和最小公倍数");
                Console.Write("请输入第一个数值：");
                int a_01 = int.Parse(Console.ReadLine());
                int aa_01 = a_01;
                Console.Write("请输入第二个数值：");
                int a_02 = int.Parse(Console.ReadLine());
                int aa_02 = a_02;
                int r = 1;
                while (r != 0)
                {
                    r = a_01 % a_02;
                    a_01 = a_02;
                    a_02 = r;
                }
                Console.WriteLine("最大公约数为：{0}", a_01);

                Console.WriteLine("最小公倍数为：{0}", aa_01 * aa_02 / a_01);

            }
            catch
            {
                Console.WriteLine("输入的数值不正确！");
            }


            Console.ReadKey();

        }
    }
}
