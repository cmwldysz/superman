﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._17
{
    class Computer                                  //父类：电脑
    {
        public string Name { get; set; }
        public string sayHello()
        {
            return "欢迎使用";
        }
    }
    class Pad : Computer                            //子类：平板电脑
    {
        public new string sayHello()                //子类重写父类方法
        {
            base.Name = "平板电脑";
            return base.sayHello() +base.Name;        //调用父类方法，在结果后添加字符串
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer();           //电脑类
            Console.WriteLine(pc.sayHello());
            Pad ipad = new Pad();                   //平板电脑类
            Console.WriteLine(ipad.sayHello());
            Console.ReadLine();
        }
    }
}
