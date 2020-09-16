using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WaresInfo info1 = new WaresInfo();
            info1.pring();
            WaresInfo info2 = new WaresInfo("0000002222", "华为手机");
            info2.pring();
            Console.ReadKey();
        }
    }
    class WaresInfo { 
        public string serialNumber;
        public string name;
        public WaresInfo() {
            this.serialNumber = "20200915";
            this.name = "麻辣香锅";
        }
        public WaresInfo(string num,string name) {
            this.serialNumber = num;
            this.name = name;
        }
        public void pring() {
            Console.WriteLine("商品编号为：{0}的商品是：{1}",serialNumber,name);
         }
    }
}
