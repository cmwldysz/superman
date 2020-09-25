using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._21
{
    abstract class ProductInfo//产品信息
    {
        public string ID;
        public string name;
        public double price; 
        public abstract void getInfo();
        public ProductInfo(string ID,string name, double price) {
            this.ID = ID;
            this.name = name;
            this.price = price;
        }
    }
    //进货
    class Stock : ProductInfo
    {
        public string stockID;//进货编号
        public override void getInfo()
        {
            Console.WriteLine("当前进货信息：");
            Console.Write("\t进货编号：{0}", this.stockID);
            Console.Write("\t产品编号：{0}", this.ID);
            Console.Write("\t产品名称：{0}", this.name);
            Console.WriteLine("\t产品价格：{0}", this.price);
        }
        public Stock(string stockID,string ID, string name, double price) :base(ID,name,price) {
            this.stockID = stockID;
        }
    }
    //出货
    class Shipment : ProductInfo
    {
        public string shipmentID;//出货编号
        public override void getInfo()
        {
            Console.WriteLine("当前出货信息：");
            Console.Write("\t出货编号：{0}", this.shipmentID);
            Console.Write("\t产品编号：{0}", this.ID);
            Console.Write("\t产品名称：{0}", this.name);
            Console.WriteLine("\t产品价格：{0}", this.price);
        }
        public Shipment(string shipmentID,string ID, string name, double price) : base(ID, name, price)
        {
            this.shipmentID = shipmentID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] pro = new ProductInfo[2];
            pro[0] = new Stock("JH001", "CP001", "笔记本电脑", 355.5);
            pro[1] = new Stock("CH001", "CP002", "Ipad", 205.5);
            foreach (ProductInfo item in pro)
            {
                item.getInfo();
            }
            Console.ReadKey();
        }
    }
}
