using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._24
{
    //产品
    interface IWares
    {
        string Name { get; set; }
        string ID { get; set; }
        void WaresInfo(int month);
    }

    //销售
    public class Mark : IWares
    {
        private string name;
        private string iD;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public Mark() { }
        public Mark(string id, string name)
        {
            ID = id;
            Name = name;
        }
        public void WaresInfo(int month)
        {
            //通过月份查询数据库中的列表明细并打印出来，如果查询列表为空输出没有数据
            {
                Mark[] MarksJan = { new Mark("T0001", "笔记本电脑"), new Mark("T0002", "华为荣耀6X"), new Mark("T0003", "iPad"),
                new Mark("T0004", "华为荣耀V9"), new Mark("T0005", "MacBook") };
                Mark[] MarksFeb = { new Mark("T0006", "华为荣耀9标配版"), new Mark("T0007", "华为荣耀9高配版") };
                Mark[] MarksMar = { new Mark("T0003", "iPad"), new Mark("T0004", "华为荣耀V9"), new Mark("T0008", "一加手机"), new Mark("T0009", "充电宝") };
                Array[] monthList = new Array[] { MarksJan, MarksFeb, MarksMar };
                if (month <= monthList.Length)
                {
                    Console.WriteLine(month + "月份的商品销售明细如下：");
                    foreach (Mark s in monthList[(month - 1)])
                        Console.WriteLine("商品编号：" + s.ID + "  商品名称：  " + s.Name);
                }
                else
                {
                    Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                }
            }
        }
    }
    class Program
    {
        //查询销售明细
        public static void QueryMarketInfo()
        {
            Console.WriteLine("—————————销售明细—————————\n\n");
            Console.Write("请输入需要查询的月份（比如1、2、3等）：");
            try
            {
                int month = Convert.ToInt32(Console.ReadLine());
                Mark mark = new Mark();
                if (month > 0 && month <= 12)
                {
                    mark.WaresInfo(month);
                }
                else
                {
                    Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                QueryMarketInfo();
            }
        }
    }
}
