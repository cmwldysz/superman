using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._17and4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.17        /////////////////////
            ///
            int line = 5; // 打印多少行
            for (int i = 0; i < line; i++)
            {
                // 列数为两倍减一
                for (int j = 0; j < (line+i); j++)
                {
                    if (line - i -1 > j)
                    {
                        Console.Write(" ");
                    }
                    else {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            /////////////////////         试题4.18        /////////////////////

            int num = 100;

            for (int i = 0; i < num/5 ; i++)
            {
                for (int j = 0; j < num/3; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        if (i + j + k == num && 5 * i + 3 * j + k / 3 == num && k%3 ==0) {
                            Console.WriteLine("100块钱买100只鸡，其中公鸡：{0}只，母鸡：{1}只，雏鸡：{2}只。", i, j, k);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
