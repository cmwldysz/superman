using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5._1andtest5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题5.1        /////////////////////
            ///
            int[] score = new int[10];
            Random rNum = new Random();
            Console.WriteLine("所有学生的数学成绩为：");
            for (int i = 0; i < score.GetLength(0); i++)
            {
                score[i] = rNum.Next(0,101);
                Console.Write(score[i]+"\t");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            /////////////////////         试题5.2       /////////////////////

            string[] card = {"梅花","方片","红桃","黑桃"};
            string[] mark = { "A", "2", "3", "4","5","6","7","8","9","10","J","Q","K" };
            Random rnum = new Random();
            int cardKey, markKey;
            for (int i = 0; i < 4; i++)
            {
                cardKey = rnum.Next(0, 4);
                markKey = rnum.Next(0, 13);
                Console.WriteLine("第{0}张牌：{1}\t{2}",i+1, card[cardKey], mark[markKey]);
            }


            Console.ReadKey();
        }
    }
}
