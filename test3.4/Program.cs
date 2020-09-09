using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'g';
            int b = 103;
            Console.WriteLine("Equals判断‘g’与103是否相等" + a.Equals(b));
            Console.WriteLine("=判断‘g’与103是否相等" + (a==b));
            Console.ReadKey();
        }
    }
}
