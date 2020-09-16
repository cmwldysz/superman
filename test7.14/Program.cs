using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("库存盘点信息如下：");
            cStockInfo stockInfo = new cStockInfo("手机", "BC9501", 200);
            stockInfo.ShowInfo();
            stockInfo.Name = "手机";
            stockInfo.TradeType = "BC9502";
            stockInfo.Num = 500; 
            stockInfo.ShowInfo();
            cStockInfo stockInfo2 = new cStockInfo();
            stockInfo2.Name = "手机";
            stockInfo2.TradeType = "BC9503";
            stockInfo2.Num = 2000;
            stockInfo2.ShowInfo();
            Console.ReadLine();
        }
    }
    class cStockInfo//库存商品类
    {
        private int num = 0;//数量
        public string Name { get; set; }//名称
        public string TradeType { get; set; }//型号
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    num = value;
                }
                else
                {
                    Console.WriteLine("商品数量输入有误！");
                }
            }
        }
        public cStockInfo() { }
        //初始化属性
        public cStockInfo(string name, string tradetype, int num)
        {
            Name = name;
            TradeType = tradetype;
            Num = num;
        }
        //用来显示库存信息
        public void ShowInfo()
        {
            Console.WriteLine("仓库中存有 {0} 型号 {1} {2}台", TradeType, Name, Num);
        }
    }
}
