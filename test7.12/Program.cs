using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._12
{
    class Bank
    {
        static double interestRate = 0.0265;//利率
        double money;//存款金额
        int ageLimit;//存款年限
        double interest = 0;//年利息
        //设置银行利率
        public void SetnterestRate(double num)
        {
            interestRate = num / 100;
        }
        //存钱
        public void Deposit()
        {
            try
            {
                Console.WriteLine("当前银行年利率为" + (interestRate * 100) + "%。");
                Console.Write("请输入存款本金：");
                money = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入存款年限：");
                ageLimit = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n操作有误！！！");
            }
        }
        //计算利息
        public void ComputeInterest()
        {
            double var = 1;
            for (int i = 1; i <= ageLimit; i++)
            {
                var *= (1 + interestRate);
            }
            interest = money * var - money;
            Console.WriteLine("{0}年后，您存入的{1}元，利息为：{2}", ageLimit, money, interest.ToString("#0.0000"));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Deposit();//开始存钱
            bank.ComputeInterest();//计算利息
            Console.WriteLine("利率变了！请输入调整后的存款利率（利率格式:2.65）：");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            bank.SetnterestRate(interestRate);//设置新的利率
            bank.Deposit();//开始存钱
            bank.ComputeInterest();//计算利息
            Console.ReadKey();
        }
    }
}
