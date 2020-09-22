using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._15
{
    class Goods { 
        public string TradeCode { get; set; }
        public string FullName { get; set; }
    }
    //进货信息
    class JHInfo : Goods { 
        public string JHID { get; set; }
        public void showInfo() {
            Console.WriteLine("进货编号：{0}\n商品编号：{1}\n商品名称：{2}",JHID,TradeCode,FullName);
        }
    }
    //销售类
    class SellInfo : Goods {
        public string XSID { get; set; }
        public void showInfo()
        {
            Console.WriteLine("销售编号：{0}\n商品编号：{1}\n商品名称：{2}", XSID, TradeCode, FullName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JHInfo jh = new JHInfo();
            jh.TradeCode = "T100001";
            jh.FullName = "笔记本电脑";
            jh.JHID = "JH00001";
            jh.showInfo();
            SellInfo xs = new SellInfo();
            xs.TradeCode = "T100001";
            xs.FullName = "笔记本电脑";
            xs.XSID = "XS00001";
            xs.showInfo();
            Console.ReadKey();
        }
    }
}
