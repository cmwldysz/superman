using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._6
{
    class iphone {
        public string language = "英文";
        public iphone() {
            language = "中文";
        }
        public iphone(string language) {
            this.language = language;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("创造第一部手机：");
            iphone sj1 = new iphone();
            Console.WriteLine("手机的默认语言为：{0}", sj1.language);
            Console.WriteLine("创造第二部手机：");
            iphone sj2 = new iphone("阿拉伯语");
            Console.WriteLine("手机的默认语言为：{0}", sj2.language);
            Console.ReadKey();
        }
    }
}
