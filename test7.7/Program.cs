using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                market.setMoney();
            }
        }
    }
    class market {
        private int consumeSum;//消费总金额
        public double discountsLaterSum;//优惠后金额

        public int ConsumeSum {
            get => consumeSum;
            set {
                consumeSum = value;
                if (value >= 3000)
                {
                    discountsLaterSum = value * 0.6;
                    Console.WriteLine("您当前购物消费总金额为：{0}，已超过3000元可享受6折优惠，优惠后金额为：{1}",ConsumeSum,discountsLaterSum);
                }
                else if (value >= 2000)
                {
                    discountsLaterSum = value * 0.7;
                    Console.WriteLine("您当前购物消费总金额为：{0}，已超过2000元可享受7折优惠，优惠后金额为：{1}", ConsumeSum, discountsLaterSum);
                }
                else if (value >= 1000)
                {
                    discountsLaterSum = value * 0.8;
                    Console.WriteLine("您当前购物消费总金额为：{0}，已超过1000元可享受8折优惠，优惠后金额为：{1}", ConsumeSum, discountsLaterSum);
                }
                else if (value >= 500)
                {
                    discountsLaterSum = value * 0.9;
                    Console.WriteLine("您当前购物消费总金额为：{0}，已超过500元可享受9折优惠，优惠后金额为：{1}", ConsumeSum, discountsLaterSum);
                }
            }
        }
        public static void setMoney() {
            try
            {
                Console.Write("请输入本次消费金额：");
                market mak = new market();
                mak.ConsumeSum = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的金额有误！！！");
            }
        }
    }
}
