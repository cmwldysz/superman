using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5._3andtest5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////         试题5.3       /////////////////////
            ///
            string[,] trainList = {
                { "T40","长春-北京","00:12","12:20","12:08"},
                { "T298","长春-北京","00:06","10:50","10:44"},
                { "Z158","长春-北京","12:48","21:06","08:18"},
                { "K1084","长春-北京","12:39","02:16","13:37"},
            };
            string[] trainInfo = new string[5];
            Console.WriteLine("从长春到北京的车票信息如下：\n");
            Console.WriteLine("车次\t\t出发站-到达站\t\t出发时间\t到达时间\t历时");
            for (int i = 0; i < trainList.GetLength(0); i++)
            {
                for (int j = 0; j < trainList.GetLength(1); j++)
                {
                    Console.Write(trainList[i,j]+"\t\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("请输入要购买的车次：");
            string train = Console.ReadLine();
            for (int i = 0; i < trainList.GetLength(0); i++)
            {
                if (trainList[i, 0] == train)
                {
                    for (int j = 0; j < trainList.GetLength(1); j++)
                    {
                        trainInfo[j] = trainList[i, j];
                    }
                    break;
                }
            }
            Console.WriteLine("请输入乘车人（用逗号分隔）：");
            string user = Console.ReadLine();
            Console.WriteLine("您已订购{0}次列车\t{1}\t{2}开，请{3}，尽快换取纸质车票。【铁路客服】", trainInfo[0], trainInfo[1], trainInfo[2],user);

            /////////////////////         试题5.4       /////////////////////
            string str = "春,眠,不,觉,晓,，,处,处,闻,啼,鸟,。,春,风,吹,又,生,，,花,落,知,多,少,。";
            string[] strList = str.Split(','); //字符串转数组
            string[,] strArray1 = new string[4, 6];
            string[,] strArray2 = new string[6, 4];
            Console.WriteLine("横向打印古诗：\n");
            for (int i = 0; i < strArray1.GetLength(0); i++)
            {
                for (int j = 0; j < strArray1.GetLength(1); j++)
                {
                    strArray1[i,j] =  strList[i * 6 + j];
                    strArray2[j, i] = strArray1[i, j];
                    Console.Write(strArray1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n纵向打印古诗：\n");
            for (int i = 0; i < strArray2.GetLength(0); i++)
            {
                for (int j = 0; j < strArray2.GetLength(1); j++)
                {
                    Console.Write(strArray2[i, j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
