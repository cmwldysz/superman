using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._15andtest4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.15        /////////////////////
            ///
            int oddSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1) {
                    oddSum += i;
                }
            }
            Console.WriteLine("0~100之间奇数的累加和为：{0}",oddSum);


            /////////////////////         试题4.16        /////////////////////

            int sum = 1;
            int num = 0;
            int o = 0;//中间变量
            for (int i = 1; i <= 30; i++)
            {
                o = sum;
                sum = sum + num;
                num = o;
                Console.Write(num + "\t");
                if(i%10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("数组1、1、2、3、5、8...到第30个数为：{0}",num);

            Console.ReadKey();
        }
    }
}
