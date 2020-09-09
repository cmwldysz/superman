using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._7and3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎登录XXX系统");
            Console.Write("请输入用户名：");
            string name = Console.ReadLine();
            string loginTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine("当前登录用户为：{0} \n登录时间为：{1}", name, loginTime);

            int holiday = 618;
            Console.WriteLine("\n\n京东年终大促开始了！");
            Console.WriteLine("京东  {0}  正式开启……", holiday);
            Console.WriteLine("京东  {0}  正式开启……", holiday.ToString());
            Console.ReadKey();
        }
    }
}
