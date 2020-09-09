using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3._11andtest3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题3.11        /////////////////////
            int a = 5, b = 8;
            Console.WriteLine("现在有两个链球：A重{0}KG，B重{1}KG \n\n", a, b);
            bool c = a > b;
            if (c)
            {
                Console.WriteLine("比较结果：A球比B球重");
            }
            else
            {
                Console.WriteLine("比较结果：B球比A球重");
            }


            /////////////////////         试题3.12        /////////////////////
            Console.WriteLine("\n\n\n\n");
            int A = 2, B = 4;

            Console.WriteLine((A > 2) ? "A家庭属于超生家庭" : "A家庭不属于超生家庭");
            Console.WriteLine((B > 2) ? "B家庭属于超生家庭" : "B家庭不属于超生家庭");

            Console.ReadKey();
        }
    }
}
