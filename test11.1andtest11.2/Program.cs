using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11._1andtest11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题11.1        /////////////////////
            ///
            try {
                checked //内存溢出
                {
                    int iNum1, iNum2, Num;
                    iNum1 = iNum2 = 60000000;
                    Num = iNum1 * iNum2;
                    Console.WriteLine("{0}*{1}={2}", iNum1, iNum2, Num);
                }
            } catch (OverflowException ex) {
                Console.WriteLine("当前程序引发OverflowException异常：" + ex.Message);
            } finally {
                Console.WriteLine("程序结束");
            }
            

            /////////////////////         试题11.2        /////////////////////


            Console.ReadKey();
        }
    }
}
