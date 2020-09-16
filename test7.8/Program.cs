using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank account = new Bank();//创建银行账户
            account.inMoney(new DateTime(2017, 05, 06), 2000);//存入
            account.inMoney(new DateTime(2017, 05, 08), 3000);
            account.inMoney(new DateTime(2017, 06, 01), 5000);
            account.inMoney(new DateTime(2017, 06, 11), 1000);

            account.outMoney(new DateTime(2017, 07, 05), 200);//取出
            account.outMoney(new DateTime(2017, 08, 02), 400);
            account.outMoney(new DateTime(2017, 09, 10), 600);
            account.outMoney(new DateTime(2017, 10, 01), 300);
            account.Display();
            Console.ReadLine();
        }
    }
    class Bank {
        DateTime[] dtime = new DateTime[100];//操作日期
        double[] Money = new double[100];//操作金额
        double[] Rest = new double[100];//余额
        double balance;// 当前余额
        int top;
        internal void inMoney(DateTime date, double money)
        {
            dtime[top] = date;
            balance += money;
            Money[top] = money;
            Rest[top] = balance;
            top++;
        }
        internal void outMoney(DateTime date, double money)
        {
            dtime[top] = date;
            balance -= money;
            Money[top] = -money;
            Rest[top] = balance;
            top++;
        }
        internal void Display()
        {
            int i = 0;
            Console.WriteLine("日期********************存入********************支出********************余额\n");
            for (i = 0; i < top; i++)
            {
                Console.Write(dtime[i].ToString("yyyy-MM-dd"));
                if (Money[i] > 0)
                {
                    Console.Write("———————" + Money[i] + "——————————————————————");
                }
                else
                {
                    Console.Write("———————————————————" + -Money[i] + "———————————");
                }
                Console.Write(Rest[i]);
                Console.WriteLine();
            }
        }
    }
}
