using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._10
{
    class Program
    {
        public void Display(ref int[] arr)
        {
            foreach (var item in arr) Console.Write(item + "\t");
        }
        public void Display(params string[] arr)
        {
            foreach (var item in arr) Console.Write(item + "\t");
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            int[] year = { 1950, 1960, 1970, 1980, 1990, 2000, 2010 };
            string[] user = { "麦肯","拉塞尔","贾巴尔","魔鸟","乔丹","邓肯","詹姆斯"};
            pr.Display(ref year);
            Console.WriteLine();
            pr.Display(user);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
