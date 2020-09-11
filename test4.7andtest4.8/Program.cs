using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4._7andtest4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题4.7        /////////////////////
            ///
            try
            {
                Console.Write("请输入您的年龄：");
                int age = int.Parse(Console.ReadLine());
                if (age > 18)
                {
                    if (age > 30)
                    {
                        if (age > 50)
                        {
                            Console.WriteLine("最美不过夕阳红！");
                        }
                        else
                        {
                            Console.WriteLine("您现在的阶段正是人生的黄金阶段！");
                        }
                    }
                    else
                    {
                        Console.WriteLine("您现在的阶段正是努力奋斗的黄金阶段！");
                    }
                }
                else
                {
                    Console.WriteLine("您的年龄还小，要努力奋斗哦！");
                }
            }
            catch
            {
                Console.WriteLine("输入的年龄不合法");
            }



            /////////////////////         试题4.8        /////////////////////

            try
            {
                Console.Write("请输入就餐人数：");
                int num = int.Parse(Console.ReadLine());
                if (num > 10)
                {
                    Console.WriteLine("抱歉，我们店暂时没有这么大的包厢！");
                }
                else
                {
                    if (num > 6)
                    {
                        Console.WriteLine("客人请到大厅10人桌用餐");
                    }
                    else
                    {
                        if (num > 4)
                        {
                            Console.WriteLine("客人请到大厅6人桌用餐");
                        }
                        else
                        {
                            if (num > 0)
                            {
                                Console.WriteLine("客人请到大厅4人桌用餐");
                            }
                            else
                            {
                                Console.WriteLine("没有用餐人员不安排桌号");
                            }
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("输入信息不正确");
            }


            Console.ReadKey();
        }
    }
}
