using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5._5andtest5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题5.5       /////////////////////
            ///
            Console.WriteLine("请输入一个英文字符串，单词与单词之间用空格隔开。");
            char[] str = Console.ReadLine().ToCharArray();
            int wordNum = 1;//单词数
            if (str.Length == 0)
            {
                wordNum = 0;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 && str[i] == ' ') {
                    wordNum = 0;
                }
                if (str[i] == ' ' && i != str.Length-1) {
                    wordNum++;
                }
            }
            Console.WriteLine("当前输入的字符串中包含{0}个单词",wordNum);

            /////////////////////         试题5.6       /////////////////////

            Console.WriteLine("购物车明细如下：\n\n");
            Console.WriteLine("商品名称\t\t数量\t价格");
            string[,] info = { { "C#项目开发实战入门", "1", "68.8" }, { "零基础学C#\t", "2", "59.8" }, { "小米6高配版\t", "1", "2899" } };
            double sum = 0;
            for (int i = 0; i < info.GetLength(0); i++)
            {
                for (int j = 0; j < info.GetLength(1); j++)
                {
                    Console.Write(info[i,j] + "\t");
                    if (j == 1) {
                        int a = Convert.ToInt32(info[i, j]);
                        double b = Convert.ToDouble(info[i, j+1]);
                        sum += (double)a * b;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("您的应付款总额为：" + sum + "元"); 
            Console.ReadKey();

        }
    }
}
