using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("visual studio 安装在   C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\");
            Console.WriteLine(@"visual studio 安装在   C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\");
            Console.WriteLine("特殊字符输出效果");
            Console.WriteLine("[\\]");
            Console.WriteLine("[\']");
            Console.WriteLine("[\"]");
            Console.WriteLine("[\u2605]");
            Console.WriteLine("[\t]");
            Console.WriteLine("[\n]");
            Console.ReadKey();
        }
    }
}
