using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._19
{
    class People {
        public virtual void Say(string name) {
            Console.WriteLine(name);
        }
    }
    class Chinese : People
    {
        public override void Say(string name)
        {
            Console.WriteLine(name +"用中文讲话！");
        }
    }
    class American : People
    {
        public override void Say(string name)
        {
            Console.WriteLine(name+ "用外语讲话！！");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入姓名：");
            string name = Console.ReadLine();
            People[] preple = { new Chinese(), new American() };
            foreach (People item in preple)
            {
                item.Say(name);
            }
            Console.ReadKey();
        }
    }
}
