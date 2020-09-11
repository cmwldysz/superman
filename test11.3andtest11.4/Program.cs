using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11._3andtest11._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题11.3        /////////////////////
            ///
            try {
                Console.WriteLine("当前账户余额为：1023.79元。");
                Console.Write("请输入取款金额：");
                int money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("取款成功，当前所剩余额：{0}元",(1023.798-money));
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("取款结束");
            }


            /////////////////////         试题11.4        /////////////////////

            Console.ReadKey();
        }
    }
}
