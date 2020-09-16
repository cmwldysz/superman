using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            WaresInfo info = new WaresInfo();
            while (true)
            {
                info.setInventory(info);
            }
        }
    }
    class WaresInfo
    {
        private int inventory;
        public int Inventory {
            get => inventory;

            set {
                if (value > 0 && value < 100)
                {
                    inventory = value;
                }
                else {
                    Console.WriteLine("输入数据不合理。");
                }
            }
        }
        public void setInventory(WaresInfo info)
        {
            Console.Write("请输入商品的库存数：");
            try
            {
                info.Inventory = Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("输入数据不合理。");
            }
        }
    }
}
