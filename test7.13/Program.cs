using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person caocao = new Person("曹操", "落荒而逃", "哈哈哈");
            Person xuhuang = new Person("徐晃", "上前拦截", "莫动我主公！");
            Person zhanghe = new Person("张郃", "上前拦截", "莫动我主公！");
            Person zhangliao = new Person("张辽", "上前拦截", "莫动我主公！");

            Person zhaoyun = new Person("赵云", "拦截去路", "吾乃常山赵子龙，曹贼哪里跑！");
            Person zhangfei = new Person("张飞", "拦截去路", "燕人张飞在此，曹贼哪里跑！");
            Person guanyu = new Person("关羽", "拦住去路", "长叹一声");

            Console.WriteLine("曹操赤壁失利，败走华容道");
            caocao.shout();
            zhaoyun.action();
            zhaoyun.shout();
            xuhuang.action();
            xuhuang.shout();
            zhanghe.action();
            zhanghe.shout();
            caocao.action();

            caocao.shout();
            zhangfei.action();
            zhangfei.shout();
            zhangliao.action();
            zhangliao.shout();
            xuhuang.action();
            xuhuang.shout();
            caocao.action();

            caocao.shout();
            guanyu.action();
            guanyu.shout();
            caocao.action();
            Console.ReadLine();
        }
    }
    class Person {
        string name; //名称
        string actionStr;//动作
        string trickStr;//话术
        public Person(string name, string actionStr, string trickStr)
        {
            this.name = name;
            this.actionStr = actionStr;
            this.trickStr = trickStr;
        }
        public void action()
        {
            Console.WriteLine(name + actionStr);
        }
        public void shout()
        {
            Console.WriteLine(name + "：" + trickStr);
        }
    }

}
