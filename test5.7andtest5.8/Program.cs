using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5._7andtest5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题5.7       /////////////////////
            ///
            List<string> list = new List<string>();
            list.Add("零基础学C#");
            list.Add("2本");
            list.Add("69.8");
            foreach (var item in list)Console.Write(item+"\t");
            Console.WriteLine();


            /////////////////////         试题5.8       /////////////////////

            Console.WriteLine("有意思的名字：");
            string[] nameList = {"王者荣耀","黄埔军校","高富帅","白富美","徐栩如生"};
            foreach (var item in nameList) Console.WriteLine(item);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
