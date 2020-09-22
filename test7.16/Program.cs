using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._16
{
    class Computer {
        //屏幕
        public string screen { get; set; }
        //开机方法
        public string startup { get; set; }
    }
    class Pad : Computer {
        //电池
        public string battery { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.screen = "液晶显示器";
            comp.startup = "电脑正在开机，请等待...";
            Pad pad = new Pad();
            pad.screen = "液晶显示器";
            pad.battery = "5000毫安电池";
            pad.startup = "电脑正在开机，请等待...";
            Console.WriteLine("Computer的屏幕是：{0}",comp.screen);
            Console.WriteLine(comp.startup);
            Console.WriteLine("pad的屏幕是：{0}", pad.screen);
            Console.WriteLine("pad的电池是：{0}", pad.battery);
            Console.WriteLine(pad.startup);

            Console.ReadKey();
        }
    }
}
