using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._21andtest4._22
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.21        /////////////////////
            ///
            Console.WriteLine("剧院可售门票信息如下：");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 1 || j == 10)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("第{0}排，第{1}列，座位可售", i, j);
                    }
                }

            }
            /////////////////////         试题4.22        /////////////////////
            Console.WriteLine("当前办公室未分配的工位有");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if ((i == 1 && j == 3) || (i == 3 && j == 2))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("当前可分配的工位有：第{0}排，第{1}个", i, j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
