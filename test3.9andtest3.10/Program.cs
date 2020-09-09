using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._9andtest3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题3.9        /////////////////////
            try
            {
                Console.WriteLine("\t简易版加法计算器\t");
                Console.WriteLine("请输入第1个数值：");
                Double number01 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第2个数值：");
                Double number02 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第3个数值：");
                Double number03 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("计算结果为：" + (number01 + number02 + number03));



                Console.WriteLine("\t简易版加法计算器\t");
                Console.WriteLine("请输入第1个数值：");
                Double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第2个数值：");
                Double number2 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第3个数值：");
                Double number3 = double.Parse(Console.ReadLine());
                Console.WriteLine("计算结果为：{0} + {1} + {2} = {3}", number1, number2, number3, (number1 + number2 + number3));
            }
            catch
            {
                Console.WriteLine("输入的数值有误！！！");
            }

            /////////////////////         试题3.10        /////////////////////
            Double a = 21.8;
            int b = 2, c = 7, d = 8, e = 28, f = 62;
            Double x = (e * d - b * f) / (a * d - b * c);
            Double y = (a * f - e * c) / (a * d - b * c);
            Console.WriteLine("二元一次方程式：\n\t21.8x + 2y = 28\n\t7x + 8y =62\n的结果为：x={0}\ty={1}", x, y);

            Console.ReadKey();
        }
    }
}
