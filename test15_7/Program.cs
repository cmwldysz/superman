using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test15_7
{
    class Program
    {
        private static object thisLock = new object();//为互斥锁准备对象
        static void PowOperation(int num, int pnum)
        {
            lock (thisLock)
            {
                try
                {
                    checked
                    {
                        long pow = 1;
                        for (int i = 0; i < pnum; i++)
                        {
                            pow *= num;
                            Thread.Sleep(100);
                        }
                        Console.WriteLine("{0}的{1}次幂是：{2}", num, pnum, pow);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message.ToString());
                }
            }
        }
        static void Main(string[] args)
        {

            Thread t1 = new Thread(new ThreadStart(() => PowOperation(2, 4)));
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(() => PowOperation(7, 50)));
            t2.IsBackground = true;
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(() => PowOperation(2, 2)));
            t3.IsBackground = true;
            t3.Start();
            Console.ReadKey();
        }
    }
}
