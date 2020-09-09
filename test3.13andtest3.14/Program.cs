using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._13andtest3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题3.13        /////////////////////
            string account = "明日";
            string tel = "136****0204";
            string email = "mingrisoft@mingrisoft.com";
            string successMsg = "登录成功！";
            string erronMsg = "登录信息错误！";
            string info;
            //方案一
            Console.WriteLine("\t欢迎登录明日学院网站\t\n");
            Console.WriteLine("请输入登录信息：");
            info = Console.ReadLine();
            if (info == account || info == tel || info == email)
            {
                Console.WriteLine(successMsg);
            }
            else
            {
                Console.WriteLine(erronMsg);
            }
            /////////////////////         试题3.14        /////////////////////

            int a = 25, b = 32;
            Console.WriteLine("现有两名男性应聘者：第一位{0}岁，第二位{1}岁，公司要求应聘者年龄在23~30岁之间\n面试结果为：", a, b);
            Console.WriteLine((a >= 23 && a <= 30) ? "第一位符合应聘要求" : "第一位不符合应聘要求");
            Console.WriteLine((b >= 23 && b <= 30) ? "第二位符合应聘要求" : "第二位不符合应聘要求");






            Console.ReadKey();
        }
    }
}
